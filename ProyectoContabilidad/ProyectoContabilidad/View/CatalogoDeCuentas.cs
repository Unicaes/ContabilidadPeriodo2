using ProyectoContabilidad.Model;
using ProyectoContabilidad.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoContabilidad.View
{
    public partial class CatalogoDeCuentas : Form
    {
        LibroDiario Padre;
        public CatalogoDeCuentas(LibroDiario oPadre)
        {
            InitializeComponent();
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Refresh();
            Padre = oPadre;
            poblarTabla();
        }

        private void poblarTabla()
        {
            this.dataGridView1.Rows.Add("1", "ACTIVO");
            this.dataGridView1.Rows.Add("11", "ACTIVOS CORRIENTE");
            this.dataGridView1.Rows.Add("1101", "EFECTIVO Y EQUIVALENTES DE EFECTIVO");
            this.dataGridView1.Rows.Add("110101", "CAJA GENERAL");
            this.dataGridView1.Rows.Add("11010102", "CAJA CHICA");
            this.dataGridView1.Rows.Add("11010103", "BANCOS");
            this.dataGridView1.Rows.Add("1101010301", "CUENTA CORRIENTE");
            this.dataGridView1.Rows.Add("1101010302", "CUENTA DE AHORRO");
            this.dataGridView1.Rows.Add("1101010304", "DEPÓSITOS A PLAZO");
            this.dataGridView1.Rows.Add("1102", "INVERSIONES A CORTO PLAZO");
            this.dataGridView1.Rows.Add("110201", "ACCIONES");
            this.dataGridView1.Rows.Add("110202", "BONOS");
            this.dataGridView1.Rows.Add("110203", "OTROS TÍTULOS VALORES");
            this.dataGridView1.Rows.Add("1103", "CUENTAS POR COBRAR");
            this.dataGridView1.Rows.Add("1104", "DOCUMENTOS POR COBRAR");
            this.dataGridView1.Rows.Add("1105", "ACCIONISTAS");
            this.dataGridView1.Rows.Add("1106", "PRESTAMOS A EMPLEADOS Y ACCIONISTAS");
            this.dataGridView1.Rows.Add("110601", "ACCIONISTAS");
            this.dataGridView1.Rows.Add("110602", "EMPLEADOS");
            this.dataGridView1.Rows.Add("1107", "OTRAS CUENTAS POR COBRAR");
            this.dataGridView1.Rows.Add("110701", "ANTICIPOS A PROVEEDORES");
            this.dataGridView1.Rows.Add("110702", "ANTICIPOS DE SALARIOS A EMPLEADOS");
            this.dataGridView1.Rows.Add("1108", "ESTIMACION POR CUENTAS INCOBRABLES");
            this.dataGridView1.Rows.Add("1109", "INVENTARIOS");
            this.dataGridView1.Rows.Add("1110", "ESTIMACION PARA DETERIORO DE INVENTAR");
            this.dataGridView1.Rows.Add("1111", "GASTOS PAGADOS POR ANTICIPADOS");
            this.dataGridView1.Rows.Add("111101", "SEGUROS");
            this.dataGridView1.Rows.Add("111102", "ALQUILERES");
            this.dataGridView1.Rows.Add("111103", "PAPELERÍA Y ÚTILES");
            this.dataGridView1.Rows.Add("111104", "PAGO A CUENTA");
            this.dataGridView1.Rows.Add("111105", "OTROS GASTOS PAGADOS POR ANTICIPADOS");
            this.dataGridView1.Rows.Add("1112", "IVA CREDITO FISCAL");
            this.dataGridView1.Rows.Add("1113", "IVA PAGADO POR ANTICIPADO");
            this.dataGridView1.Rows.Add("111301", "IVA PERCIBIDO");
            this.dataGridView1.Rows.Add("111302", "IVA RETENIDO");
            this.dataGridView1.Rows.Add("1114", "PAGO A CUENTA");
            this.dataGridView1.Rows.Add("12", "ACTIVOS NO CORRIENTES");
            this.dataGridView1.Rows.Add("1201", "PROPIEDAD PLANTA Y EQUIPO");
            this.dataGridView1.Rows.Add("120101", "TERRENOS");
            this.dataGridView1.Rows.Add("120102", "EDIFICIOS");
            this.dataGridView1.Rows.Add("120103", "INSTALACIONES");
            this.dataGridView1.Rows.Add("120104", "EQUIPO DE REPARTO");
            this.dataGridView1.Rows.Add("120105", "MOBILIARIO Y EQUIPO");
            this.dataGridView1.Rows.Add("1202", "DEPRECIACIONES");
            this.dataGridView1.Rows.Add("120201", "EDIFICIO");

            this.dataGridView1.Rows.Add("120202", "INSTALACIONES");
            this.dataGridView1.Rows.Add("120203", "EQUIPO DE REPARTO");
            this.dataGridView1.Rows.Add("120204", "MOBILIARIO Y EQUIPO");
            this.dataGridView1.Rows.Add("1203", "INSTANGIBLES");
            this.dataGridView1.Rows.Add("120301", "CRÉDITO MERCANTIL");
            this.dataGridView1.Rows.Add("120302", "PATENTES Y MARCAS");
            this.dataGridView1.Rows.Add("120303", "LICENCIAS");
            this.dataGridView1.Rows.Add("1204", "AMORTIZACION DE INTANGIBLES");
            this.dataGridView1.Rows.Add("120401", "CRÉDITO MERCANTIL");
            this.dataGridView1.Rows.Add("120402", "PATENTES Y MARCAS");
            this.dataGridView1.Rows.Add("120403", "LICENCIAS");
            this.dataGridView1.Rows.Add("1205", "INVERSIONES PERMANENTES");
            this.dataGridView1.Rows.Add("1206", "IMPUESTO SOBRE LA RENTA DIFERIDO");
            this.dataGridView1.Rows.Add("2", "PASIVO");
            this.dataGridView1.Rows.Add("21", "PASIVOS CORRIENTE");
            this.dataGridView1.Rows.Add("2101", "SOBREGIROS BANCARIOS");
            this.dataGridView1.Rows.Add("2102", "PROVEEDORES");
            this.dataGridView1.Rows.Add("210201", "LOCALES");
            this.dataGridView1.Rows.Add("210202", "EXTRANJEROS");
            this.dataGridView1.Rows.Add("2103", "DOCUMENTOS POR COBRAR DESCONTADOS");
            this.dataGridView1.Rows.Add("210301", "PAGARES");
            this.dataGridView1.Rows.Add("210302", "LETRAS DE CAMBIO");
            this.dataGridView1.Rows.Add("210303", "BONOS");
            this.dataGridView1.Rows.Add("210304", "OTROS TÍTULOS VALORES");
            this.dataGridView1.Rows.Add("2104", "DOCUMENTOS POR PAGAR");
            this.dataGridView1.Rows.Add("210401", "PAGARES");
            this.dataGridView1.Rows.Add("210402", "LETRAS DE CAMBIO");
            this.dataGridView1.Rows.Add("210403", "BONOS");
            this.dataGridView1.Rows.Add("210404", "OTROS TÍTULOS VALORES");
            this.dataGridView1.Rows.Add("2105", "PRESTAMOS POR PAGAR");
            this.dataGridView1.Rows.Add("210501", "BANCARIOS");
            this.dataGridView1.Rows.Add("210502", "ACCIONISTAS");
            this.dataGridView1.Rows.Add("210503", "OTROS");
            this.dataGridView1.Rows.Add("2106", "RETENCIONES POR PAGAR");
            this.dataGridView1.Rows.Add("210601", "ISSS (SALUD)");
            this.dataGridView1.Rows.Add("210602", "ISSS (PENSIÓN)");
            this.dataGridView1.Rows.Add("210603", "AFP");
            this.dataGridView1.Rows.Add("210604", "RENTA");
            this.dataGridView1.Rows.Add("210605", "IVA");
            this.dataGridView1.Rows.Add("2107", "PROVISIONES POR PAGAR");
            this.dataGridView1.Rows.Add("210701", "ISSS (SALUD)");
            this.dataGridView1.Rows.Add("210702", "ISSS (PENSIÓN)");
            this.dataGridView1.Rows.Add("210703", "AFP");
            this.dataGridView1.Rows.Add("210704", "INSAFORP");
            this.dataGridView1.Rows.Add("210705", "PAGO A CUENTA");

            this.dataGridView1.Rows.Add("2108", "DIVIDENDOS POR PAGAR");
            this.dataGridView1.Rows.Add("2109", "IVA DEBITO FISCAL");
            this.dataGridView1.Rows.Add("2110", "IVA PERCIBIDO Y RETENIDO POR PAGAR");
            this.dataGridView1.Rows.Add("211001", "IVA PERCIBIDO");
            this.dataGridView1.Rows.Add("211002", "IVA RETENIDO");
            this.dataGridView1.Rows.Add("2111", "IMPUESTO POR PAGAR");
            this.dataGridView1.Rows.Add("211101", "PAGO A CUENTA");
            this.dataGridView1.Rows.Add("211102", "RENTA");
            this.dataGridView1.Rows.Add("211103", "IVA");
            this.dataGridView1.Rows.Add("211104", "OTROS");
            this.dataGridView1.Rows.Add("2112", "CUENTAS POR PAGAR");
            this.dataGridView1.Rows.Add("2113", "INTERESES POR PAGAR");
            this.dataGridView1.Rows.Add("22", "PASIVO NO CORRIENTE");
            this.dataGridView1.Rows.Add("2201", "PRESTAMOS POR PAGAR");
            this.dataGridView1.Rows.Add("2202", "DOCUMENTOS POR PAGAR");
            this.dataGridView1.Rows.Add("2203", "INGRESOS DIFERIDOS");
            this.dataGridView1.Rows.Add("2204", "PROVISION PARA OBLIGACIONES LABORALES");
            this.dataGridView1.Rows.Add("2205", "PASIVO POR IMPUESTO DE RENTA DIFERIDO");
            this.dataGridView1.Rows.Add("3", "PATRIMONIO");
            this.dataGridView1.Rows.Add("31", "CAPITAL CONTABLE");
            this.dataGridView1.Rows.Add("3101", "CAPITAL SOCIAL");
            this.dataGridView1.Rows.Add("3102", "RESERVA LEGAL");
            this.dataGridView1.Rows.Add("3103", "UTILIDADES RETENIDAS");
            this.dataGridView1.Rows.Add("3104", "UTILIDAD DEL EJERCICIO");
            this.dataGridView1.Rows.Add("3105", "R PÉRDIDAS");
            this.dataGridView1.Rows.Add("310501", "R PÉRDIDAS ACUMULADAS");
            this.dataGridView1.Rows.Add("310502", "R PÉRDIDAS DEL PRESENTE EJERCICIO");
            this.dataGridView1.Rows.Add("4", "CUENTAS DE RESULTADO ACREEDORAS");
            this.dataGridView1.Rows.Add("41", "COSTOS Y GASTOS DE OPERACION");
            this.dataGridView1.Rows.Add("4101", "COMPRAS");
            this.dataGridView1.Rows.Add("4102", "GASTOS SOBRE COMPRAS");
            this.dataGridView1.Rows.Add("4103", "COSTO DE VENTA");
            this.dataGridView1.Rows.Add("42", "GASTOS OPERATIVOS");
            this.dataGridView1.Rows.Add("4201", "GASTOS DE ADMINISTRACION");
            this.dataGridView1.Rows.Add("420101", "SUELDOS Y SALARIOS");
            this.dataGridView1.Rows.Add("420102", "COMISIONES");
            this.dataGridView1.Rows.Add("420103", "VACACIONES");
            this.dataGridView1.Rows.Add("420104", "BONIFICACIONES");
            this.dataGridView1.Rows.Add("420105", "AGUINALDOS");
            this.dataGridView1.Rows.Add("420106", "HORAS EXTRAS");
            this.dataGridView1.Rows.Add("420107", "VIÁTICOS");
            this.dataGridView1.Rows.Add("420108", "INDEMNIZACIONES");
            this.dataGridView1.Rows.Add("420109", "ATENCIONES AL PERSONAL");
            this.dataGridView1.Rows.Add("420110", "ISSS (SALUD)");
            this.dataGridView1.Rows.Add("420111", "ISSS (PENSIÓN)");

            this.dataGridView1.Rows.Add("420112", "AFP");
            this.dataGridView1.Rows.Add("420113", "HONORARIOS");
            this.dataGridView1.Rows.Add("420115", "SEGUROS");
            this.dataGridView1.Rows.Add("420116", "TRANSPORTES");
            this.dataGridView1.Rows.Add("420117", "AGUA");
            this.dataGridView1.Rows.Add("420118", "COMUNICACIONES");
            this.dataGridView1.Rows.Add("420119", "ENERGÍA ELÉCTRICA");
            this.dataGridView1.Rows.Add("420120", "ESTIMACIÓN PARA CUENTAS INCOBRABLES");
            this.dataGridView1.Rows.Add("420121", "PAPELERÍA Y ÚTILES");
            this.dataGridView1.Rows.Add("420122", "DEPRECIACIÓN");
            this.dataGridView1.Rows.Add("420123", "MANTENIMIENTO Y REPARACIÓN DE MOBILIARIO Y EQUIPO");
            this.dataGridView1.Rows.Add("420124", "MANTENIMIENTO Y REPARACIÓN DE EDIFICIOS");
            this.dataGridView1.Rows.Add("420125", "MANTENIMIENTO Y REPARACIONES DE EQUIPO DE REPARTO");
            this.dataGridView1.Rows.Add("420126", "PUBLICIDAD");
            this.dataGridView1.Rows.Add("420127", "EMPAQUES");
            this.dataGridView1.Rows.Add("420128", "ATENCIONES A CLIENTES");
            this.dataGridView1.Rows.Add("420129", "MULTAS");
            this.dataGridView1.Rows.Add("420130", "COMBUSTIBLES Y LUBRICANTES");
            this.dataGridView1.Rows.Add("420131", "IMPUESTOS MUNICIPALES");
            this.dataGridView1.Rows.Add("420132", "INSCRIPCIONES");
            this.dataGridView1.Rows.Add("420133", "LIMPIEZAS");
            this.dataGridView1.Rows.Add("420134", "ALQUILERES");
            this.dataGridView1.Rows.Add("420135", "MATRICULAS DE COMERCIO");
            this.dataGridView1.Rows.Add("420136", "DONACIONES Y CONTRIBUCIONES");
            this.dataGridView1.Rows.Add("420137", "VIGILANCIAS");
            this.dataGridView1.Rows.Add("420138", "UNIFORMES");
            this.dataGridView1.Rows.Add("420139", "AMORTIZACIONES");
            this.dataGridView1.Rows.Add("420140", "ORNATOS");
            this.dataGridView1.Rows.Add("420141", "OTROS");
            this.dataGridView1.Rows.Add("4202", "GASTOS DE VENTAS");
            this.dataGridView1.Rows.Add("4201", "GASTOS DE ADMINISTRACION");
            this.dataGridView1.Rows.Add("4203", "REBAJAS Y DEVOLUCIONES SOBRE VENTAS");
            this.dataGridView1.Rows.Add("4204", "DESCUENTOS SOBRE VENTAS");
            this.dataGridView1.Rows.Add("43", "GASTOS NO OPERATIVOS");
            this.dataGridView1.Rows.Add("4301", "GASTOS FINANCIEROS");
            this.dataGridView1.Rows.Add("430101", "INTERESES");
            this.dataGridView1.Rows.Add("430102", "COMISIONES BANCARIAS");
            this.dataGridView1.Rows.Add("430103", "DIFERENCIAL CAMBIARIO");
            this.dataGridView1.Rows.Add("4302", "PERDIDAS EN VENTA DE ACTIVO FIJO");
            this.dataGridView1.Rows.Add("4303", "GASTOS POR IMPUESTOS");
            this.dataGridView1.Rows.Add("4304", "OTROS GASTOS");
            this.dataGridView1.Rows.Add("5", "CUENTAS DE RESULTADO ACREEDORAS");
            this.dataGridView1.Rows.Add("51", "INGRESOS DE OPERACIÓN");
            this.dataGridView1.Rows.Add("5101", "VENTAS");
            this.dataGridView1.Rows.Add("5102", "REBAJAS Y DEVOLUCIONES SOBRE COMPRAS");

            this.dataGridView1.Rows.Add("5103", "DESCUENTOS SOBRE COMPRAS");
            this.dataGridView1.Rows.Add("52", "INGRESOS DE NO OPERACIÓN");
            this.dataGridView1.Rows.Add("5201", "INTERESES");
            this.dataGridView1.Rows.Add("5202", "UTILIDAD EN VENTA DE ACTIVO FIJO");
            this.dataGridView1.Rows.Add("5203", "OTROS INGRESOS");
            this.dataGridView1.Rows.Add("5204", "INGRESO POR IMPUESTO DE RENTA DIFERIDO");
            this.dataGridView1.Rows.Add("6", "CUENTA DE CIERRE");
            this.dataGridView1.Rows.Add("61", "CUENTA LIQUIDADORA");
            this.dataGridView1.Rows.Add("6101", "PÉRDIDAS Y GANANCIAS");
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            var fila = this.dataGridView1.CurrentCell.RowIndex;
            Singleton.Instance.codigo = Convert.ToInt32(this.dataGridView1.Rows[fila].Cells[0].Value);
            Singleton.Instance.descripcion = this.dataGridView1.Rows[fila].Cells[1].Value.ToString();
            Padre.cargarDatos();
            this.Dispose();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            String query = this.txtSearch.Text.ToUpper();
            int index = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value.ToString().Contains(query))
                {
                    index = row.Index;
                    break;
                }

                else if (row.Cells[0].Value.ToString().Contains(query))
                {
                    index = row.Index;
                    break;
                }
            }
            dataGridView1.Rows[index].Selected = true;
            dataGridView1.FirstDisplayedScrollingRowIndex = index;
            this.txtSearch.Clear();
        }
    }
}