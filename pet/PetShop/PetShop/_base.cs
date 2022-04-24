using DAO;
using DAO.model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop
{
    public class _base : Controller
    {
        public void LimparSessao()
        {
            HttpContext.Session.Clear();
        }


        public int CodigoLogado
        {
            set
            {
                HttpContext.Session.SetInt32("cod", value);
            }
            get
            {
                if (HttpContext == null || HttpContext.Session.GetInt32("cod") == null || HttpContext.Session.GetInt32("cod") == 0)
                {
                    return -100; //Não está logado
                }
                else
                {
                    return Convert.ToInt32(HttpContext.Session.GetInt32("cod"));
                }
            }
        }

        public bool VerificarLogado()
        {
            return CodigoLogado == -100 ? false : true;
        }

        public enum Paginas
        {
            NovoCliente,
            ConsultarCliente,
            AlterarCliente,
            SelecionarCliente,
            NovoFuncionario,
            ConsultarFuncionario,
            AlterarFuncionario,
            GerenciarAnimal,
            NovoAtendimento,
            ConsultarAtendimento,
            AlterarAtendimento,
            Login
        }

        public void PaginaAtual(Paginas p)
        {
            switch (p)
            {
                case Paginas.NovoCliente:
                    ViewBag.Titulo = "Novo Cliente";
                    ViewBag.SubTitulo = "Aqui você poderá cadastrar seus clientes";
                    break;
                case Paginas.ConsultarCliente:
                    ViewBag.Titulo = "Consultar Cliente";
                    break;
                case Paginas.AlterarCliente:
                    ViewBag.Titulo = "Alterar Cliente";
                    ViewBag.SubTitulo = "Aqui você poderá alterar o cadastro dos seus clientes";
                    break;
                case Paginas.SelecionarCliente:
                    ViewBag.Titulo = "Selecionar Cliente";
                    ViewBag.SubTitulo = "Aqui você vizualizar os atendimentos a seus clientes";
                    break;
                case Paginas.NovoFuncionario:
                    ViewBag.Titulo = "Novo Funcionário";
                    ViewBag.SubTitulo = "Aqui você poderá cadastrar seus funcionários";
                    break;
                case Paginas.ConsultarFuncionario:
                    ViewBag.Titulo = "Consultar Funcionário";
                    break;
                case Paginas.AlterarFuncionario:
                    ViewBag.Titulo = "Alterar Funcionário";
                    ViewBag.SubTitulo = "Aqui você poderá alterar o cadastro dos seus funcionários";
                    break;
                case Paginas.GerenciarAnimal:
                    ViewBag.Titulo = "Gerenciar Animal";
                    ViewBag.SubTitulo = "Aqui você poderá gerenciar os animais";
                    break;
                case Paginas.NovoAtendimento:
                    ViewBag.Titulo = "Novo Atendimento";
                    ViewBag.SubTitulo = "Aqui você poderá cadastrar seus atendimentos";
                    break;
                case Paginas.ConsultarAtendimento:
                    ViewBag.Titulo = "Consultar Atendimento";
                    break;
                case Paginas.AlterarAtendimento:
                    ViewBag.Titulo = "Alterar Atendimento";
                    ViewBag.SubTitulo = "Aqui você poderá alterar seus atendimentos";
                    break;
                case Paginas.Login:
                    break;
                default:
                    break;
            }
        }

        public void CarregarEstados()
        {
            List<TbEstado> lstEstados = new GeralDAO().CarregarEstados();
            ViewBag.Estados = lstEstados;
        }

        public void FiltrarCidades(int idEstado)
        {
            List<TbCidade> lstCidades = new GeralDAO().FiltrarCidades(idEstado);
            ViewBag.Cidades = lstCidades;
        }

        public JsonResult FiltrarCidadesJS(int idEstado)
        {
            List<TbCidade> lstCidade = new GeralDAO().FiltrarCidades(idEstado);
            return Json(lstCidade);
        }

    }
}
