namespace Ex02_Cofre;

public class Cofre
{
    private string dono;
    private string senha;
    private bool estaAberto;
    private int tentativasErradas;

    public bool EstaAberto => estaAberto;
    public string Dono => dono;

    public Cofre(string dono, string senhaInicial)
    {
        this.dono = dono;
        this.senha = senhaInicial;
        this.estaAberto = false;
        this.tentativasErradas = 0;
    }

    public string Abrir(string senhaInformada)
    {
        if (tentativasErradas >= 3)
            return "Cofre Bloqueado";

        if (senhaInformada == senha)
        {
            estaAberto = true;
            tentativasErradas = 0;
            return "Cofre aberto com sucesso";
        }

        tentativasErradas++;
        return "Senha incorreta";
    }

    public void Fechar()
    {
        estaAberto = false;
    }

    public string AlterarSenha(string senhaAntiga, string novaSenha)
    {
        if (!estaAberto)
            return "Cofre fechado";

        if (senhaAntiga != senha)
            return "Senha antiga inválida";

        senha = novaSenha;
        return "Senha alterada com sucesso";
    }

    public override string ToString()
    {
        return $"Dono: {dono} | Aberto: {estaAberto} | Tentativas: {tentativasErradas}";
    }
}