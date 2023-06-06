public class Voo
{
    public int numeroVoo;
    public DateTime data;
    public bool[] cadeiras = new bool[100];
    

    public Voo(int numeroVoo, DateTime data)
    {
        this.numeroVoo = numeroVoo;
        this.data = data;
    }   

    public DateTime GetData()
    {
        return this.data;
    }

    public int GetNumeroVoo()
    {
        return numeroVoo;
    }
    public void SetNumeroVoo(int numeroVoo)
    {
        this.numeroVoo = numeroVoo;
    }

}
