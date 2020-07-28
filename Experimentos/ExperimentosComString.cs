using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Experimentos {
    public class ExperimentosComString {



        public string Concatena2Strings(string valorA, string valorB) {
            //se o a tiver espaço ou o b tiver espaço, não concatena com espaço. 
            return valorA.Trim() + " " + valorB.Trim();
        }

        public string CapitalizarString(string frase) {


            string[] listaDePalavras = frase.Split(' ');
            string saida = "";
            foreach (string palavra in listaDePalavras) {

                saida += palavra.Substring(0, 1).ToUpper();
                saida += palavra.Substring(1).ToLower();
                saida += " ";
            }



            return saida.Trim(); ;
        }



        public string CapitalizarString2(string frase) {



            string saida = "";
            bool inicioDePalavra = true;
            bool entrePalavras = true;
            foreach (char letra in frase) {


                if (letra == ' ') {
                    inicioDePalavra = false;
                    entrePalavras = true;
                    saida += letra.ToString();
                   
                   
                    
                
                }

                else {
                    if (entrePalavras) {
                        entrePalavras = false;
                        inicioDePalavra = true;
                    }

                    if (inicioDePalavra) {
                        saida += letra.ToString().ToUpper();
                        inicioDePalavra = false;
                    }
                    else {
                        saida += letra.ToString().ToLower();

                    }
                }

            }



            return saida;
        }


        public string FormataPercentual(float percentual, int casas) {
            string totalCalculo = percentual.ToString("n" + casas) + "%";



            return totalCalculo;

        }




    }


}






