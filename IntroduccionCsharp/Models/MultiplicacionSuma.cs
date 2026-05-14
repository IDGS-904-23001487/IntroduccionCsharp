using IntroduccionCsharp.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroduccionCsharp.Models

{

    public class MultiplicacionSuma
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Resultado { get; set; }
        public string ResultadoTexto { get; set; }


        public void Multiplicar()

        {
            this.Resultado = 0;
            this.ResultadoTexto = "";
            for (int i = 0; i < this.Num2; i++)

            {
                this.Resultado = this.Resultado + this.Num1;
                this.ResultadoTexto = this.ResultadoTexto + this.Num1.ToString();
                if (i < (this.Num2 - 1))

                {

                    this.ResultadoTexto = this.ResultadoTexto + " + ";

                }

            }
            this.ResultadoTexto = this.ResultadoTexto + " = " + this.Resultado.ToString();

        }

    }

}