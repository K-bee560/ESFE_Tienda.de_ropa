using ESFE_Tienda.de_ropa.DAL;
using ESFE_Tienda.de_ropa.EN;

namespace ESFE_Tienda.de_ropa.LN
{
    public class TelaLN
    {
        private readonly TelaDAL telaDAL;

        public TelaLN()
        {
            telaDAL = new TelaDAL();
        }

        // =====================================================
        // BUSCAR TELA POR CÓDIGO
        // =====================================================

        public Tela BuscarPorCodigo(string codigoTela)
        {
            if (string.IsNullOrWhiteSpace(codigoTela))
            {
                throw new Exception(
                    "Debe ingresar el código de la tela.");
            }

            codigoTela = codigoTela.Trim();

            return telaDAL.BuscarPorCodigo(codigoTela);
        }
    }
}