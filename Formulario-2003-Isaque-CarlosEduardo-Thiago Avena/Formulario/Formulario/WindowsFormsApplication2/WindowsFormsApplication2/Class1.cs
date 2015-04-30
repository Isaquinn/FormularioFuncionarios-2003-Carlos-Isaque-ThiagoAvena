using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication2
{
    
        class Funcionario
        {
            public string nome, idade, sexo, cargo, salario, email, filhos, endereco, telefone, sangue, civil, imagem ;

            public string asString()
            {
                return nome + "#" + idade + "#" + sexo + "#" + cargo + "#" + salario + "#" + email + "#" + filhos + "#" + endereco + "#" + telefone + "#" + sangue + "#" + civil + "#" + imagem;
            }
        }
    
}
