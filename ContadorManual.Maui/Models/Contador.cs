namespace ContadorManual.Maui.Models
{
    public class Contador
    {
        int _conteo;
        public int Conteo
        {
            get { return _conteo; }
        }
        public Contador()
        {
            _conteo = 0;
        }

        public void Contar()
        {
            _conteo++;
        }
        public void Reiniciar()
        {
            _conteo = 0;
        }
    }
}
