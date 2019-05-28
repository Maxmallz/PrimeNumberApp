<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="PrimeNumberApp.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Prime Number Generator</title>
    <link rel="stylesheet" href="main.css" />
</head>
<body>
    <img src="" />
    <h1 class="heading">Prime Number Generator</h1>
    <p class="website-description"></p>

    <section class ="navigations">
        <ul>
            <li><a href ="#IsPrime">Prime Number Checher</a></li>
            <li><a href ="#PrimeBetween">Prime Number Range</a></li>
            <li><a href ="#PrimeCount">All Primes</a></li>
        </ul>
    </section>

    <div>
        <form id="mainForm" runat="server">
            <section id="IsPrime">
                <h2>Prime Number Checker</h2>
                <asp:Label ID="isPrimeErrorLbl" runat="server"></asp:Label>
                <asp:Label Text="Enter Number:" runat="server"></asp:Label>
                &nbsp
            <asp:TextBox ID="isPrimeTxt" runat="server"></asp:TextBox>
                <asp:Button ID="isPrimeBtn" Text="Check" OnClick="isPrimeBtn_Click" runat="server" />
                <br />
                <asp:Label ID="primeNosTxt" ReadOnly="true" runat="server"></asp:Label>
            </section>

            <section id="PrimeBetween">
                <h2>Get Prime Numbers Within a Range</h2>
                <asp:Label ID="primeBetweenErrorLbl" runat="server"></asp:Label>
                <div class="min-value">MinValue:
                    <asp:TextBox ID="minValueTxt" runat="server"></asp:TextBox></div>
                <div class="max-value">MaxValue:
                    <asp:TextBox ID="maxValueTxt" runat="server"></asp:TextBox></div>
                <br />
                <asp:Button ID="getPrimeRangeBtn" Text="Check" OnClick="getPrimeRangeBtn_Click" runat="server" />
                <br />
                <asp:TextBox ID="primeNosRangeTxt" ReadOnly="true" runat="server"></asp:TextBox>
            </section>

            <section id="PrimeCount">
                                <h2>Get Prime Numbers</h2>
                <asp:Label ID="primeNoListErrorLabel" runat="server"></asp:Label>
                <asp:Label Text="Enter Total Prime Numbers:" runat="server"></asp:Label>
                &nbsp
            <asp:TextBox ID="totalPrimeTxt" runat="server"></asp:TextBox>
                <asp:Button ID="getAllPrimes" Text="Submit" OnClick="getAllPrimes_Click" runat="server" />
                <br />
                <asp:TextBox ID ="allPrimesTxt" ReadOnly ="true" runat="server"></asp:TextBox>
            </section>

        </form>
    </div>
</body>
</html>
