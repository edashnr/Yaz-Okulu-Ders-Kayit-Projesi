<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Anasayfa.aspx.cs" Inherits="YazOkuluDersler.Anasayfa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
<style>
        html, body {
            height: 100%;
            margin: 0;
            overflow: hidden;
        }
        #form1 {
            height: 100%;
            display: flex;
            justify-content:stretch;
            align-items:stretch;
            background-color: #f0f0f0; /* İsteğe bağlı olarak arka plan rengini ayarla */
        }
        #resimContainer {
            text-align: center; /* Resmi ortalamak için kullanılır */
        }
        #resim {
            max-width: 100%; /* Resmin maksimum genişliğini ayarla */
            max-height: 100%; /* Resmin maksimum yüksekliğini ayarla */
            width: auto;
            height: auto;
        }
    </style>

    <form id="form1" runat="server">
        <div id="resimContainer">
            <img id="resim" src="images/Ekran görüntüsü 2024-05-22 153827.png" alt="Resim Açıklaması" />
        </div>
    </form>

     <script>
         // Sayfa yüklendiğinde ve yeniden boyutlandırıldığında resmin boyutlarını ayarla
         window.onload = function () {
             resizeImage();
         };

         window.onresize = function () {
             resizeImage();
         };

         function resizeImage() {
             var img = document.getElementById("resim");
             var windowWidth = window.innerWidth;
             var windowHeight = window.innerHeight;

             var imageWidth = img.naturalWidth;
             var imageHeight = img.naturalHeight;

             var widthRatio = windowWidth / imageWidth;
             var heightRatio = windowHeight / imageHeight;

             if (widthRatio > heightRatio) {
                 img.style.width = windowWidth + "px";
                 img.style.height = "auto";
             } else {
                 img.style.width = "auto";
                 img.style.height = windowHeight + "px";
             }
         }
     </script>
</asp:Content>
