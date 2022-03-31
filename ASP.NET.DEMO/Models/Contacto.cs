namespace ASP.NET.DEMO.Models
{
    public class Contacto
    {
        public int IdContacto { get; set; }
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public override string ToString() => Nombre;
        
        List<Contacto> Contactos = new List<Contacto>();

        public void Add(Contacto pContacto)
        {

        }
        public void Delete(int pIdContacto)
        {

        }
        public void Update(Contacto pContacto)
        {

        }
        public IReadOnlyList<Contacto> GetContactos()
        {
            Contactos.Add(new Contacto
            {
                IdContacto = 1,
                Nombre = "David Vázquez Palestino",
                CorreoElectronico = "david.vazquez@intelix.mx",
                Telefono = "2711413901"
            });
            Contactos.Add(new Contacto
            {
                IdContacto = 2,
                Nombre = "Julissa Martínez de Aquino",
                CorreoElectronico = "julissa.martinez@intelix.mx",
                Telefono = "2715593268"
            });
            Contactos.Add(new Contacto
            {
                IdContacto = 3,
                Nombre = "Miguel Ángel Lobato Arellano",
                CorreoElectronico = "miguel.lobato@intelix.mx",
                Telefono = "2721167768"
            });
            return Contactos;
        }

    }
}
