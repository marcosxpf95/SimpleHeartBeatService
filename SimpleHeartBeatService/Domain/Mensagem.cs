using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleHeartBeatService
{
    class Mensagem
    {
        public string EmailRemetente { get; set; }
        public string PasswordRemetente { get; set; }
        public string EmailDestinatario { get; set; }        
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public string Rodape { get; set; }

        public Mensagem(string EmailRemetente, string PasswordRemetente,string EmailDestinatario, string Titulo)
        {
            this.EmailRemetente = EmailRemetente;
            this.EmailDestinatario = EmailDestinatario;
            this.PasswordRemetente = PasswordRemetente;
            this.Titulo = Titulo;            
            setarTextoEmail();
        }

        public void setarTextoEmail()
        {
            this.Texto = "<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">" +
                           " <html xmlns=\"http://www.w3.org/1999/xhtml\" >                                                                                                                    " +
                           "<head>                                                                                                                                                              " +
                           "<title> Cobrança Mensal Itaú </title>                                                                                                                                      " +
                           "</head>                                                                                                                                                             " +
                           "<body>                                                                                                                                                              " +
                           "<br>                                                                                                                                                                " +
                           "<p>                                                                                                                                                                 " +
                           "<H1>Regularize imediatamente!!!</p>                                                                                         " +
                           "</h1>                                                                                                                                                           " +
                           "<b> Em nosso sistema consta, em sua conta, uma prestação vencida há mais de 10 dias, por conta disso, pedimos sua regularização imediata. <br><br>" +
                           "Dados da compra: </b>" +                          
                           "<p> Produto: MacBook Air Apple Core i5 8GB 128GB SSD Tela 13.3” MacOS Sierra MQD32BZ/A </p>" +
                           "<p> Valor: R$5.000,00 </p>" +                           
                           "<p> Data Vencimento: 02/04/2020. </p>" + 
                           "<br><br><b> Se a conta não for paga brevemente. Resultará na inclusão dos seus dados no SPC, Serasa e outras empresas de proteção ao crédito.</b>" +
                           "<br><br>" +                           
                           "<br><br> Agradecemos sua compreensão" +
                           "<footer>                                                                                                                                                            " +
                           "<br>                                                                                                                                                                " +
                           "    <i>Itaú, cuidando da saúde fincanceira dos nossos clientes!</i> <br>" +
                           "    <a href=\"https://www.itau.com.br/emprestimos-financiamentos/emprestimo-pessoal/?gclid=CjwKCAjw1cX0BRBmEiwAy9tKHgl9pJcsx0xRXr5LjJPxQJI_TIIoSUk5pPMizjqhH7bwDXLSxsKdVxoC6L0QAvD_BwE&utm_source=gog&utm_medium=cpc&utm_content=af003-goog-gog-ca027-nd-cpc-all-keyw-cred_ia-nd-paid-VS00003266&ef_id=CjwKCAjw1cX0BRBmEiwAy9tKHgl9pJcsx0xRXr5LjJPxQJI_TIIoSUk5pPMizjqhH7bwDXLSxsKdVxoC6L0QAvD_BwE:G:s&s_kwcid=AL!905!3!411510852936!b!!g!!%2Bcredito%20%2Bitau\" > " +
                           "    <div width=\"100%\" style=\"background-color:  #002e26;\">                                                                                                      " +
                           "        <img src=\"https://cdn6.aptoide.com/imgs/4/9/4/494ea9c48a5beebb7a5658cde6a529c6.png\"  width =\"400\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" +                           
                           "    </div>                                                                                                                                                          " +
                           "</footer>                                                                                                                                                           " +
                           "</html>";
                           
        }

    }
}
