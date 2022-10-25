namespace Projeto.Converter
{
    public static class EstadoHelper
    {
        public static bool PossuiValor(this int valor)
            => valor > 0;

        public static bool PossuiValor(this int? valor)
             => valor != null && valor.GetValueOrDefault() > 0;

        public static bool PossuiValor(this long valor)
             => valor > 0;

        public static bool PossuiValor(this decimal valor)
             => valor > 0;

        public static bool PossuiValor(this object valor)
             => valor != null;

        public static bool PossuiValor(this Guid valor)
             => valor != null && valor != Guid.Empty;

        public static bool PossuiValor(this Guid? valor)
             => valor != null && valor != Guid.Empty;

        public static bool PossuiValor(this string valor)
             => !string.IsNullOrWhiteSpace(valor);

        public static bool PossuiValor<T>(this IEnumerable<T> valor)
             => valor != null && valor.Count() > 0;

        public static bool PossuiValor(this byte[] valor)
             => valor != null && valor.Length > 0;

        public static bool PossuiValor(this DateTime valor)
             => valor != null && valor != DateTime.MinValue && valor.Date != Convert.ToDateTime("01/01/1753").Date;

        public static bool PossuiValor(this DateTime? valor)
             => valor != null && valor != DateTime.MinValue && valor.GetValueOrDefault().Date != Convert.ToDateTime("01/01/1753").Date;
    }
}
