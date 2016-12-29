Public Class FrmMenu

    Private Sub DatosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub MaterialToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MaterialToolStripMenuItem.Click
        FrmMaterial.MdiParent = Me
        FrmMaterial.Show()
    End Sub

    Private Sub MaquinaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MaquinaToolStripMenuItem.Click
        FrmMaquina.MdiParent = Me
        FrmMaquina.Show()
    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClienteToolStripMenuItem.Click
        FrmCliente.MdiParent = Me
        FrmCliente.Show()
    End Sub

    Private Sub VehiculoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VehiculoToolStripMenuItem.Click
        FrmVehiculo.MdiParent = Me
        FrmVehiculo.Show()
    End Sub

    Private Sub CargaMasivaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargaMasivaToolStripMenuItem.Click
        FrmVehiculoCargarPlaca.MdiParent = Me
        FrmVehiculoCargarPlaca.Show()
    End Sub

    Private Sub VentaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VentaToolStripMenuItem.Click
        FrmContrato.MdiParent = Me
        FrmContrato.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        FrmEmpleado.MdiParent = Me
        FrmEmpleado.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        If MessageBox.Show("Desea salir de la aplicacion", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.ExitThread()
        End If
    End Sub

    Private Sub RemisionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RemisionToolStripMenuItem.Click
        FrmRemision.MdiParent = Me
        FrmRemision.Show()
    End Sub

    Private Sub VerVentaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VerVentaToolStripMenuItem.Click
        FrmContratoVenta.Show()
        FrmContratoVenta.MdiParent = Me
    End Sub

    Private Sub DiarioToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmInformeDiario.MdiParent = Me
        FrmInformeDiario.Show()
    End Sub

    Private Sub MensualToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmInformeMensual.MdiParent = Me
        FrmInformeMensual.Show()
    End Sub

    Private Sub InformeDiarioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InformeDiarioToolStripMenuItem.Click
        FrmHorometro_Tanqueo.MdiParent = Me
        FrmHorometro_Tanqueo.Show()
    End Sub

    Private Sub DiarioToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DiarioToolStripMenuItem1.Click
        FrmInformeDiario.MdiParent = Me
        FrmInformeDiario.Show()
    End Sub

    Private Sub MensualToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MensualToolStripMenuItem1.Click
        FrmInformeMensual.MdiParent = Me
        FrmInformeMensual.Show()
    End Sub

    Private Sub Mt3CargadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Mt3CargadosToolStripMenuItem.Click
        FrmInformeMt3Cargados.MdiParent = Me
        FrmInformeMt3Cargados.Show()
    End Sub

    Private Sub ClientesXContratoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesXContratoToolStripMenuItem.Click
        FrmInformeContratoVenta.MdiParent = Me
        FrmInformeContratoVenta.Show()
    End Sub

    Private Sub AbonosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbonosToolStripMenuItem.Click
        FrmAbonos.MdiParent = Me
        FrmAbonos.Show()
    End Sub

    Private Sub AbonosXContratoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbonosXContratoToolStripMenuItem.Click
        FrmAbonosxContratos.MdiParent = Me
        FrmAbonosxContratos.Show()
    End Sub

    Private Sub DiarioToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles DiarioToolStripMenuItem.Click
        FrmInformeMaquinaDiario.MdiParent = Me
        FrmInformeMaquinaDiario.Show()
    End Sub
End Class