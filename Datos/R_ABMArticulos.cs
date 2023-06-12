﻿using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity;

namespace Datos
{
    public class R_ABMArticulos
    {
        private Modelo repositorio;

        public R_ABMArticulos()
        {
            repositorio = new Modelo();
        }

        public List<articulo> Actualizar()
        {
            return repositorio.articulos.Where(x => x.febaj == null).ToList();
        }

        public void AgregarProducto(articulo p)
        {
            //int id_siguiente = repositorio.articulos.OrderByDescending(x => x.id).FirstOrDefault().id + 1;
            p.fealt = DateTime.Now;
            //p.id = id_siguiente;
            
            repositorio.articulos.Add(p);
            repositorio.SaveChanges();
        }

        public void EditarProducto(articulo p)
        {
            articulo _articulo = repositorio.articulos.Where(x => x.id == p.id).FirstOrDefault();

            _articulo.id = p.id;
            _articulo.Codigo = p.Codigo;
            _articulo.Descripcion = p.Descripcion;
            _articulo.CostoSinIva = p.CostoSinIva;
            _articulo.PorcentajeIva = p.PorcentajeIva;
            _articulo.MargenDeGanancia = p.MargenDeGanancia;
            _articulo.Estado = p.Estado;
            _articulo.femod = DateTime.Now;
            _articulo.stock = p.stock;
            _articulo.CategoriaId = p.CategoriaId;
            _articulo.categoria = p.categoria;            
            
            
            repositorio.SaveChanges();
        }

        public void EliminarProducto(articulo p)
        {
            var _producto = repositorio.articulos.Where(x => x.id == p.id).FirstOrDefault();
            _producto.febaj = DateTime.Now;
            //repositorio.articulos.Remove(_producto);
            repositorio.SaveChanges();
        }

        public List<articulo> BuscarProductos(string nombre)
        {
            return repositorio.articulos.Where(x => x.Descripcion.Contains(nombre)).ToList();
        }

        public List<categoria> Buscar_Todas_Categorias()
        {
            return repositorio.categorias.Where(x => x.febaj == null).ToList();
        }

        public List<categoria> Buscar_Todas_Categorias_Item()
        {          
           return repositorio.categorias.Where(x => x.febaj == null).ToList();           
        }

        public categoria GetCategoria(int idcategoria)
        {
            return repositorio.categorias.Where(p => p.febaj == null && p.id == idcategoria).FirstOrDefault();
        }

        public articulo BuscarArticuloId(int idarticulo)
        {
            return repositorio.articulos.Where(p => p.febaj == null && p.id == idarticulo).FirstOrDefault();
        }
    }
}
