﻿using Datos;
using Dominio;
using Dominio.ViewModels;
using Interfaces;
using Sistema.Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentadores
{
    public class PresentadorGestionArticulos
    {
        IGestionProducto _vista;
        RepositorioABMArticulos _repositorio;

        public PresentadorGestionArticulos(IGestionProducto vistaPar)
        {
            _vista = vistaPar;
            _repositorio = new RepositorioABMArticulos();
        }


        public List<GestionArticulosViewModel> ActualizarListado()
        {
            return _repositorio.Actualizar().Select(p => new GestionArticulosViewModel
            {
                IdArticulo = p.Id,
                DescripcionArticulo = p.Descripcion,
                CostoSinIva = p.CostoSinIva,
                CostoConIva = p.CostoConIva,
                PrecioFinal = p.Preciofinal,
                EstadoProducto = p.Estado,
                NombreCategoria = p.Categoria.Nombre
            }).ToList();
            
        }

        public List<GestionArticulosViewModel> BuscarProductos(string nombre)
        {
            
            return _repositorio.BuscarProductos(nombre).Select(p => new GestionArticulosViewModel
            {
                IdArticulo = p.Id,
                DescripcionArticulo = p.Descripcion,
                CostoSinIva = p.CostoSinIva,
                CostoConIva = p.CostoConIva,
                PrecioFinal = p.Preciofinal,
                EstadoProducto = p.Estado,
                NombreCategoria = p.Categoria.Nombre
            }).ToList(); ;
            
        }

        //TODO: El presentador no debe conocer los formularios directamente
        //de lo contrario no tiene mucho sentido utilizar el patrón MVP
        

        public Articulo DevolverArticulo(int idArticulo)
        {
            Articulo _articulo = _repositorio.BuscarArticulo(idArticulo);
            return _articulo;
           
        }

        
    }
}
