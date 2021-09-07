using System;

namespace DIO.series
{
    public class Serie : EndidadeBase
    {
        // Atributos
        private Genero Genero { get; set; }

        private string Titulo { get; set; }

        private string Descricao  { get; set; }

        private int Ano  { get; set; }

        private bool Excluido { get; set; }

        //Métodos

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.Genero = genero;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString() 
        {
            // Enviroment.NewLine https://docs.microsoft.com/pt-br/dotnet/api/system.environment.newline?view=net-5.0

            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }

    }
}