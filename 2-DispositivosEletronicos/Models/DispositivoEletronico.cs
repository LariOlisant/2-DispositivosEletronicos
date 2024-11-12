namespace _2_DispositivosEletronicos.Models
{
    public abstract class DispositivoEletronico
    {
        public string Marca { get; set; } //get obtem set guarda

        public string Modelo { get; set; }

        public int AnoDeFabricacao { get; set; }
        //é um método

        public abstract string ExibirDetalhes();
    }
}
