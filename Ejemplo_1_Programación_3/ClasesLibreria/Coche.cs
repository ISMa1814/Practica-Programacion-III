namespace ClasesLibreria;

public class Coche
{
    //Atributos van con minuscula
    private int id;
    //private string marca;
    //private string modelo;
    //private string precio;
    //private string km;

    //Las propiedades van con el mismo nombre de los atributos, solo que van con mayusculas
    //Así es como se hacian antes
    public int Id { get => id; set => id = value; }

    //Así es como se hacen ahora, y de esta forma no es necesario crearle un atributo
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public decimal Precio { get; set; }
    public int Km { get; set; }

    //Contructor
    //Este es el contructor por defecto y no es necesario declararlo, ya que C# ya lo tiene declarado
    public Coche() 
    { 
    }

    //Esta es una forma de declarar un Contructor
    public Coche(int id, string marca)
    {
        Id = id;
        Marca = marca;
    }

    //Metodos
    public string DevolverDatosCoche()
    {
        return "ID: " + Id + " Marca: " + Marca + " Modelo: " + Modelo;
    }
}
