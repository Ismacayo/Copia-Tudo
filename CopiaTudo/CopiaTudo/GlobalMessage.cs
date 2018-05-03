namespace CopiaTudo
{
    public static class GlobalMessage
    {
        public static string[] listadeArquivos;
        public static bool fechou = false;

        /// <summary>
        /// Instancia o array de string
        /// </summary>
        /// <param name="indice">indice para instacionar a list</param>
        public static void InstaciaArray(int indice)
        {
            listadeArquivos = new string[indice];
        }

        /// <summary>
        /// Seta o valor no indice selecionado no array
        /// </summary>
        /// <param name="nome">Nome para ser inserido no array</param>
        /// <param name="indice">Indice para a isenção do array</param>
        public static void SetListadeArquivos(string nome, int indice)
        {
            listadeArquivos[indice] = nome;
        }
    }
}
