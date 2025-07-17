using Newtonsoft.Json;
public class Usuario{
    [JsonProperty]
     public int Id{get; private set;}
     [JsonProperty]
    public string Nombre{get; private set;}
    [JsonProperty]
    public string Apellido{get; private set;}
    [JsonProperty]
    public string Email{get;private set;}
    [JsonProperty]
    public string Contrasena{get;private set;}
    [JsonProperty]
    public DateTime FechaNacimiento{get;private set;}
    [JsonProperty]
    public string Foto{get;private set;}
    
    public void Inicializar(string Nombre, int Id, string Apellido, string Email, string Contrasena, DateTime FechaNacimiento, string Foto){
        this.Id= Id;
        this.Nombre= Nombre;
        this.Apellido=Apellido;
        this.Email=Email;
        this.Contrasena=Contrasena;
        this.FechaNacimiento=FechaNacimiento;
        this.Foto=Foto;
    }
    public int ObtenerEdad(){
        return FechaNacimiento.Year - DateTime.Now.Year;
    }

}
    