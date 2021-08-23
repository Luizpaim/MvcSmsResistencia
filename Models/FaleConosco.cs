using System;
using MvcSmsResistencia.Models;


namespace MvcSmsResistencia.Models
{
    public class FaleConosco
    {
        public int Id {get;set;}
        public string Nome {get;set;}
        public string Empresa {get;set;}
        public string Email {get;set;}
        public string Telefone {get;set;}
        public string Conheceu {get;set;}
        public string Mensagem {get;set;}
    }
}