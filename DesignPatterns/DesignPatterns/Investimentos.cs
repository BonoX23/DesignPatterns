using System;

public class ContaBancaria
{
    public double Saldo { get; private set; }

    public void Deposita(double valor)
    {
        Saldo += valor;
    }
}

public interface Investimento
{
    double Calcula(ContaBancaria contaBancaria);
}

public class RealizadorDeInvestimento
{
    public void Realiza (ContaBancaria contaBancaria, Investimento investimento)
    {
        double resultado = investimento.Calcula(contaBancaria);
        contaBancaria.Deposita(resultado * 0.75);
        Console.WriteLine("Novo Saldo " + contaBancaria.Saldo);
    }
}

public class Conservador : Investimento
{
    public double Calcula(ContaBancaria contaBancaria)
    {
        return contaBancaria.Saldo * 0.008  ;
    }
}

public class Moderado : Investimento
{
    private Random random;

    public Moderado()
    {
        this.random = new Random();
    }

    public double Calcula(ContaBancaria contaBancaria)
    {
        if (random.Next(2) == 0)
            return contaBancaria.Saldo * 0.025;
        else
            return contaBancaria.Saldo * 0.007;
    }
}

public class Arrojado : Investimento
{
    private Random random;

    public Arrojado()
    {
        this.random = new Random();
    }

    public double Calcula(ContaBancaria contaBancaria)
    {
        int chute = random.Next(10);
        if (chute >= 0 && chute <= 4)
            return contaBancaria.Saldo * 0.5;
        else if (chute >= 2 && chute <= 4)
            return contaBancaria.Saldo * 0.3;
        else return contaBancaria.Saldo * 0.006;
    }
}
