namespace Atv._06
{
    public abstract class Animal
    {
        public string Especie { get; set; }

        public abstract void EmitirSom();
    }

    public class Gato : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Minhauu Minhauuu");
        }
    }

    public class Porco : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Heeeemmm Heeeemmmmm");
        }
    }

    public class Capivara : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("IIIIIIII");
        }
    }
}