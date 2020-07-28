using Experimentos;
using System;
using System.Threading.Tasks;

public class ExperimentosComNumerosStrings
{
    public ExperimentosComNumeros experimentosComNumeros = new ExperimentosComNumeros();
    public ExperimentosComString experimentosComString = new ExperimentosComString();
        
        
        
        
        public string CalculaEFormataPercentual(float parte, float todo, int casas) {

            float percentual = experimentosComNumeros.CalculaPercentual(parte, todo);
            string formatado = experimentosComString.FormataPercentual(percentual, casas);

            return formatado;

            //string percentual = ((parte * 100) / todo).ToString("n2");
            //return percentual + "%";
        }
    
}
