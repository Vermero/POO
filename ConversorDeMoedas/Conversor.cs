using static System.Console;
using System;

public class Conversor
{
    public float cotacao;
    public float dolares;
    public float reais;
    
    public void Conta()
    {
        
        reais = dolares * cotacao;
        
        float iof = 0.06f * reais;
        WriteLine("Imposto sobre Operações Financeiras: " + iof);

        reais -= iof;

        WriteLine("Valor a ser pago em reais: " + reais);
    }
}
