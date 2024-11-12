namespace _2_DispositivosEletronicos.Models
{
    public class Computador : DispositivoEletronico
    {
        public bool Ehlaptop { get; set; } //get obtem set guarda


        public int MemoriaRam { get; set; }


        public string SistemaOperacional { get; set; }

        public override string ExibirDetalhes()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Ano: {AnoDeFabricacao}, SO: {SistemaOperacional} ";
        }
    }
}
