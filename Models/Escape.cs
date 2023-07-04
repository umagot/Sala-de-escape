public static class Escape
{
    private static string[] incognitasSalas =  new string[] {"", "BBACCB", "Edgar Allan Poe", "JARDINERO", "El miedo", "La sombra"};
    private static int estadoJuego = 1;
    private static void inicializarJuego()
    {
    }
    public static int getEstadoJuego()
    {
        return estadoJuego;
    }
    public static bool resolverSala(int Sala, string Clave)
    {
        bool esCorrecto=incognitasSalas[Sala] == Clave;
        if(esCorrecto){
            estadoJuego++;
        }
        return esCorrecto;
    }
    
}