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
    public string Contraseña{get;private set;}
    [JsonProperty]
    public DateTime FechaNacimiento{get;private set;}
    [JsonProperty]
    public string Foto{get;private set;}
    
    public Usuario(string Nombre, int Id, string Apellido, string Email, string Contraseña, DateTime FechaNacimiento, string Foto){
        this.Id= Id;
        this.Nombre= Nombre;
        this.Apellido=Apellido;
        this.Email=Email;
        this.Contraseña=Contraseña;
        this.FechaNacimiento=FechaNacimiento;
        this.Foto=Foto;
    }
    public int ObtenerEdad(){
        return FechaNacimiento.Year - DateTime.Now.Year;
    }

}
    