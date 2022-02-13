using DAO.model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Helpers;

namespace DAO
{
    public class GeralDAO : _baseDAO
    {
        public List<TbEstado> CarregarEstados()
        {
            List<TbEstado> lstEstados = banco.TbEstado.ToList();
            return lstEstados;
        }

        public List<TbCidade> FiltrarCidades(int idEstado)
        {
            List<TbCidade> lstCidades = banco.TbCidade.Where(c => c.EstadoId == idEstado).ToList();
            return lstCidades;
        }
    }
}