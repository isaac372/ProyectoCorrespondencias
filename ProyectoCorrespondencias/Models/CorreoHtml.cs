using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCorrespondencias.Models
{
    public class CorreoHtml
    {
        public string GetInicioDocHtml()
        {
            var x = @"<!DOCTYPE html>
                  <html xmlns=http://www.w3.org/1999/xhtml>";
            return x;
        }

        public string GetFinDocHtml()
        {
            var x = "</html>";
            return x;
        }

        public string GetHeadHtml()
        {
            var x = "<head> <meta http-equiv=\"Content-type\" content=\"text/html;charset=UTF-8\"/> <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\"/> <style type=\"text/css\"> p{margin: 10px 0; padding: 0;}table{border-collapse: collapse;}h1, h2, h3, h4, h5, h6{display: block; margin: 0; padding: 0;}img, a img{border: 0; height: auto; outline: none; text-decoration: none;}body, #bodyTable, #bodyCell{height: 100%; margin: 0; padding: 0; width: 100%;}#outlook a{padding: 0;}img{-ms-interpolation-mode: bicubic;}table{mso-table-lspace: 0pt; mso-table-rspace: 0pt;}.ReadMsgBody{width: 100%;}.ExternalClass{width: 100%;}p, a, li, td, blockquote{mso-line-height-rule: exactly;}a[href^=tel], a[href^=sms]{color: inherit; cursor: default; text-decoration: none;}p, a, li, td, body, table, blockquote{-ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%;}.ExternalClass, .ExternalClass p, .ExternalClass td, .ExternalClass div, .ExternalClass span, .ExternalClass font{line-height: 100%;}a[x-apple-data-detectors]{color: inherit !important; text-decoration: none !important; font-size: inherit !important; font-family: inherit !important; font-weight: inherit !important; line-height: inherit !important;}a.mcnButton{display: block;}.mcnImage{vertical-align: bottom;}.mcnTextContent{word-break: break-word;}.mcnTextContent img{height: auto !important;}.mcnDividerBlock{table-layout: fixed !important;}/* @tab Page @section background style @tip Set the background color and top border for your email. You may want to choose colors that match your company's branding. */ body, #bodyTable, #templateFooter{/*@editable*/ background-color: #fff;}/* @tab Page @section background style @tip Set the background color and top border for your email. You may want to choose colors that match your company's branding. */ #bodyCell{/*@editable*/ border-top: 0;}/* @tab Page @section heading 1 @tip Set the styling for all first-level headings in your emails. These should be the largest of your headings. @style heading 1 */ h1{/*@editable*/ color: #D83826 !important; /*@editable*/ font-family: Helvetica; /*@editable*/ font-size: 30px; /*@editable*/ font-style: normal; /*@editable*/ font-weight: bold; /*@editable*/ line-height: 125%; /*@editable*/ letter-spacing: -1px; /*@editable*/ text-align: center;}/* @tab Page @section heading 2 @tip Set the styling for all second-level headings in your emails. @style heading 2 */ h2{/*@editable*/ color: #404040 !important; /*@editable*/ font-family: Helvetica; /*@editable*/ font-size: 26px; /*@editable*/ font-style: normal; /*@editable*/ font-weight: bold; /*@editable*/ line-height: 150%; /*@editable*/ letter-spacing: normal; /*@editable*/ text-align: center;}/* @tab Page @section heading 3 @tip Set the styling for all third-level headings in your emails. @style heading 3 */ h3{/*@editable*/ color: #808080 !important; /*@editable*/ font-family: Helvetica; /*@editable*/ font-size: 18px; /*@editable*/ font-style: normal; /*@editable*/ font-weight: bold; /*@editable*/ line-height: 125%; /*@editable*/ letter-spacing: normal; /*@editable*/ text-align: center;}/* @tab Page @section heading 4 @tip Set the styling for all fourth-level headings in your emails. These should be the smallest of your headings. @style heading 4 */ h4{/*@editable*/ color: #CCCCCC !important; /*@editable*/ font-family: Helvetica; /*@editable*/ font-size: 10px; /*@editable*/ font-style: normal; /*@editable*/ font-weight: normal; /*@editable*/ line-height: 125%; /*@editable*/ letter-spacing: normal; /*@editable*/ text-align: center;}/* @tab Preheader @section preheader style @tip Set the background color and borders for your email's preheader area. */ #templatePreheader{/*@editable*/ background-color: #fff; /*@editable*/ border-top: 0; /*@editable*/ border-bottom: 0;}/* @tab Preheader @section preheader text @tip Set the styling for your email's preheader text. Choose a size and color that is easy to read. */ .preheaderContainer .mcnTextContent, .preheaderContainer .mcnTextContent p{/*@editable*/ color: #808080; /*@editable*/ font-family: Helvetica; /*@editable*/ font-size: 10px; /*@editable*/ line-height: 125%; /*@editable*/ text-align: left;}/* @tab Preheader @section preheader link @tip Set the styling for your email's header links. Choose a color that helps them stand out from your text. */ .preheaderContainer .mcnTextContent a{/*@editable*/ color: #606060; /*@editable*/ font-weight: normal; /*@editable*/ text-decoration: underline;}/* @tab Header @section header style @tip Set the background color and borders for your email's header area. */ #templateHeader{/*@editable*/ background-color: #fff; /*@editable*/ border-top: 0; /*@editable*/ border-bottom: 0;}/* @tab Header @section header text @tip Set the styling for your email's header text. Choose a size and color that is easy to read. */ .headerContainer .mcnTextContent, .headerContainer .mcnTextContent p{/*@editable*/ color: #606060; /*@editable*/ font-family: Helvetica; /*@editable*/ font-size: 16px; /*@editable*/ line-height: 150%; /*@editable*/ text-align: left;}/* @tab Header @section header link @tip Set the styling for your email's header links. Choose a color that helps them stand out from your text. */ .headerContainer .mcnTextContent a{/*@editable*/ color: #D83826; /*@editable*/ font-weight: bold; /*@editable*/ text-decoration: none;}/* @tab Body @section body style @tip Set the background color and borders for your email's body area. */ #templateBody, .leafContainer{/*@editable*/ background-color: #fff;}/* @tab Body @section body style @tip Set the background color and borders for your email's body area. */ #templateBody{/*@editable*/ border-top: 0; /*@editable*/ border-bottom: 0;}/* @tab Body @section body text @tip Set the border for your email's body text container. */ #bodyBackground{/*@tab Body @section body text @tip Set the border for your email's body text container.*/ background-color: #FFFFFF; /*@editable*/ border: 1px solid #E5E5E5;}/* @tab Body @section body text @tip Set the styling for your email's body text. Choose a size and color that is easy to read. */ .bodyContainer .mcnTextContent, .bodyContainer .mcnTextContent p{/*@editable*/ color: #606060; /*@editable*/ font-family: Helvetica; /*@editable*/ font-size: 16px; /*@editable*/ line-height: 150%; /*@editable*/ text-align: left;}/* @tab Body @section body text @tip Set the styling for your email's body text. Choose a size and color that is easy to read. */ .bodyContainer{/*@editable*/ border-left: 2px dashed #93c959;}/* @tab Body @section body link @tip Set the styling for your email's body links. Choose a color that helps them stand out from your text. */ .bodyContainer .mcnTextContent a{/*@editable*/ color: #543680; /*@editable*/ font-weight: bold; /*@editable*/ text-decoration: none;}/* @tab Footer @section footer style @tip Set the borders for your email's footer area. */ #templateFooter{/*@editable*/ border-top: 0; /*@editable*/ border-bottom: 0;}/* @tab Footer @section footer text @tip Set the styling for your email's footer text. Choose a size and color that is easy to read. */ .footerContainer .mcnTextContent, .footerContainer .mcnTextContent p{/*@editable*/ color: #808080; /*@editable*/ font-family: Helvetica; /*@editable*/ font-size: 10px; /*@editable*/ line-height: 125%; /*@editable*/ text-align: center;}/* @tab Footer @section footer link @tip Set the styling for your email's footer links. Choose a color that helps them stand out from your text. */ .footerContainer .mcnTextContent a{/*@editable*/ color: #606060; /*@editable*/ font-weight: normal; /*@editable*/ text-decoration: underline;}@media only screen and (max-width: 480px){body, table, td, p, a, li, blockquote{-webkit-text-size-adjust: none !important;}}@media only screen and (max-width: 480px){body{width: 100% !important; min-width: 100% !important;}}@media only screen and (max-width: 480px){#bodyCell{padding-top: 10px !important;}}@media only screen and (max-width: 480px){.templateContainer{max-width: 600px !important; width: 100% !important; background-color: #fff;}}@media only screen and (max-width: 480px){.leafContainer{width: 10px !important;}}@media only screen and (max-width: 480px){.mobileHide{display: none !important;}}@media only screen and (max-width: 480px){.mcnImage{height: auto !important; width: 100% !important;}}@media only screen and (max-width: 480px){.mcnCartContainer, .mcnCaptionTopContent, .mcnRecContentContainer, .mcnCaptionBottomContent, .mcnTextContentContainer, .mcnBoxedTextContentContainer, .mcnImageGroupContentContainer, .mcnCaptionLeftTextContentContainer, .mcnCaptionRightTextContentContainer, .mcnCaptionLeftImageContentContainer, .mcnCaptionRightImageContentContainer, .mcnImageCardLeftTextContentContainer, .mcnImageCardRightTextContentContainer{max-width: 100% !important; width: 100% !important;}}@media only screen and (max-width: 480px){.mcnBoxedTextContentContainer{min-width: 100% !important;}}@media only screen and (max-width: 480px){.mcnImageGroupContent{padding: 9px !important;}}@media only screen and (max-width: 480px){.mcnCaptionLeftContentOuter .mcnTextContent, .mcnCaptionRightContentOuter .mcnTextContent{padding-top: 9px !important;}}@media only screen and (max-width: 480px){.mcnImageCardTopImageContent, .mcnCaptionBlockInner .mcnCaptionTopContent:last-child .mcnTextContent{padding-top: 18px !important;}}@media only screen and (max-width: 480px){.mcnImageCardBottomImageContent{padding-bottom: 9px !important;}}@media only screen and (max-width: 480px){.mcnImageGroupBlockInner{padding-top: 0 !important; padding-bottom: 0 !important;}}@media only screen and (max-width: 480px){.mcnImageGroupBlockOuter{padding-top: 9px !important; padding-bottom: 9px !important;}}@media only screen and (max-width: 480px){.mcnTextContent, .mcnBoxedTextContentColumn{padding-right: 18px !important; padding-left: 18px !important;}}@media only screen and (max-width: 480px){.mcnImageCardLeftImageContent, .mcnImageCardRightImageContent{padding-right: 18px !important; padding-bottom: 0 !important; padding-left: 18px !important;}}@media only screen and (max-width: 480px){.mcpreview-image-uploader{display: none !important; width: 100% !important;}}@media only screen and (max-width: 480px){/* @tab Mobile Styles @section heading 1 @tip Make the first-level headings larger in size for better readability on small screens. */ h1{/*@editable*/ font-size: 24px !important; /*@editable*/ line-height: 125% !important;}}@media only screen and (max-width: 480px){/* @tab Mobile Styles @section heading 2 @tip Make the second-level headings larger in size for better readability on small screens. */ h2{/*@editable*/ font-size: 20px !important; /*@editable*/ line-height: 125% !important;}}@media only screen and (max-width: 480px){/* @tab Mobile Styles @section heading 3 @tip Make the third-level headings larger in size for better readability on small screens. */ h3{/*@editable*/ font-size: 18px !important; /*@editable*/ line-height: 125% !important;}}@media only screen and (max-width: 480px){/* @tab Mobile Styles @section heading 4 @tip Make the fourth-level headings larger in size for better readability on small screens. */ h4{/*@editable*/ font-size: 16px !important; /*@editable*/ line-height: 125% !important;}}@media only screen and (max-width: 480px){/* @tab Mobile Styles @section Boxed Text @tip Make the boxed text larger in size for better readability on small screens. We recommend a font size of at least 16px. */ .mcnBoxedTextContentContainer .mcnTextContent, .mcnBoxedTextContentContainer .mcnTextContent p{/*@editable*/ font-size: 18px !important; /*@editable*/ line-height: 125% !important;}}@media only screen and (max-width: 480px){/* @tab Mobile Styles @section Preheader Visibility @tip Set the visibility of the email's preheader on small screens. You can hide it to save space. */ #templatePreheader{/*@editable*/ display: block !important;}}@media only screen and (max-width: 480px){/* @tab Mobile Styles @section Preheader Text @tip Make the preheader text larger in size for better readability on small screens. */ .preheaderContainer .mcnTextContent, .preheaderContainer .mcnTextContent p{/*@editable*/ font-size: 14px !important; /*@editable*/ line-height: 115% !important;}}@media only screen and (max-width: 480px){/* @tab Mobile Styles @section Header Text @tip Make the header text larger in size for better readability on small screens. */ .headerContainer .mcnTextContent, .headerContainer .mcnTextContent p{/*@editable*/ font-size: 18px !important; /*@editable*/ line-height: 125% !important;}}@media only screen and (max-width: 480px){/* @tab Mobile Styles @section Body Text @tip Make the body text larger in size for better readability on small screens. We recommend a font size of at least 16px. */ .bodyContainer .mcnTextContent, .bodyContainer .mcnTextContent p{/*@editable*/ font-size: 18px !important; /*@editable*/ line-height: 125% !important;}}@media only screen and (max-width: 480px){/* @tab Mobile Styles @section footer text @tip Make the body content text larger in size for better readability on small screens. */ .footerContainer .mcnTextContent, .footerContainer .mcnTextContent p{/*@editable*/ font-size: 14px !important; /*@editable*/ line-height: 115% !important;}}</style></head>";
            return x;
        }

        public string GetBodyHtml()
        {
            var x = "<body style=\"font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; font-size: 14px; line-height: 1.42857143; color: #333; background-color: #fff;\"> <center>";
            return x;
        }

        public string GetFinBodyHtml()
        {
            var x = "</center></body>";
            return x;
        }

        public string DataHtml(Plantilla plantilla)
        {
            var x = @"<table class=""body-wrap"">
          <tr>
              <td></td>
              <td class=""container"" width=""600"">
                <div class=""content"">
                    <table class=""main"" width=""100%"" cellpadding=""0"" cellspacing=""0"">
                        <tr>
                            <td class=""content-wrap"">
                                <table cellpadding = ""0"" cellspacing=""0"">
                                    <tr>
                                        <td>
                                            <img class=""img-responsive"" src=""https://img.freepik.com/vector-gratis/feliz-cumpleanos-concepto_23-2148484501.jpg?size=338&ext=jpg""/>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class=""content-block"">
                                            <h3>@Titulo</h3>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class=""content-block"">
                                    @Descripcion
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class=""content-block"">
                                          @Direccion
                                        </td>
                                    </tr>
                                    <tr>
                                       <td class=""content-block"">
                                          @Fecha
                                        </td>
                                    </tr>
                                    <tr>
                                       <td class=""content-block"">
                                          @Contribucion
                                        </td>
                                    </tr>
                                    <tr>
                                       <td class=""content-block"">
                                         Estas invitado   @Contacto
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                    <div class=""footer"">
                        <table width = ""100%"">
                            <tr>
                                <td class=""aligncenter content-block"">Correspondencia</td>
                            </tr>
                        </table>
                    </div>
                </div>
            </td>
            <td></td>
        </tr>
    </table>";
            x = x.Replace("@Titulo", plantilla.Titulo);
            x = x.Replace("@Descripcion", plantilla.Descripcion);
            x = x.Replace("@Direccion", plantilla.Direccion);
            x = x.Replace("@Fecha", plantilla.Fecha.ToString());
            x = x.Replace("@Contribucion", plantilla.Contribucion);
            x = x.Replace("@Contacto", plantilla.Contacto);
            return x;
        }


    }
}
