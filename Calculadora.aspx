<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="WeBcalculadora.Calculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Calculadora</title>
    <link href="css/Estilo1.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">

       

        <h1>Calculadora UH</h1>
        <br />

        <div>
           
            <asp:Label ID="lresultado" runat="server" Font-Size="XX-Large" ForeColor="black" class="disenodemarco"></asp:Label>
           </div>

            <br />

            <asp:Button ID="b1" class="button button2" Text="1" runat="server" OnClick="b1_Click" />
            <asp:Button ID="b2" class="button button2" Text="2" runat="server" OnClick="b2_Click" />
            <asp:Button ID="b3" class="button button2" Text="3" runat="server" OnClick="b3_Click" />
            <asp:Button ID="b4" class="button button2" Text="4" runat="server" OnClick="b4_Click" />
            <asp:Button ID="b5" class="button button2" Text="5" runat="server" OnClick="b5_Click" />
            <asp:Button ID="b6" class="button button2" Text="6" runat="server" OnClick="b6_Click" />
            <asp:Button ID="b7" class="button button2" Text="7" runat="server" OnClick="b7_Click" />
            <asp:Button ID="b8" class="button button2" Text="8" runat="server" OnClick="b8_Click" />
            <asp:Button ID="b9" class="button button2" Text="9" runat="server" OnClick="b9_Click" />
            <asp:Button ID="b0" class="button button2" Text="0" runat="server" OnClick="b0_Click" />
            <asp:Button ID="bsuma" class="button button3" Text="+" runat="server" OnClick="bsuma_Click" />
            <asp:Button ID="bresta" class="button button3" Text="-" runat="server" OnClick="bresta_Click" />
            <asp:Button ID="bmultiplicacion" class="button button3" Text="*" runat="server" OnClick="bmultiplicacion_Click" />
            <asp:Button ID="bdivision" class="button button3" Text="/" runat="server" OnClick="bdivision_Click" />

            <asp:Button ID="bpotencia2" class="button button3" Text="x²" runat="server" OnClick="bpotencia2_Click" />
            <asp:Button ID="bpotencia3" class="button button3" Text="x³" runat="server" OnClick="bpotencia3_Click" />
            <asp:Button ID="braiz" class="button button3" Text="√" runat="server" OnClick="braizcuadrada_Click" />

            <asp:Button ID="bFactorial" class="button button3" Text="n!" runat="server" OnClick="bfactorial_Click" />
            <asp:Button ID="bFibonnaci" class="button button3" Text="F" runat="server" OnClick="bFibonnaci_Click" />

            <asp:Button ID="bresultado" class="button button4" Text="=" runat="server" OnClick="bresultado_Click" />
            <asp:Button ID="bclear" class="button button5" Text="C" runat="server" OnClick="bclear_Click" />

    </form>
</body>
</html>
