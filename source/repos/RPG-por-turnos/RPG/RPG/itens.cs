using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class itens
    {
        string[,] equipamentos = new string[21, 5];

        public void cadastraritens()
        {

            equipamentos[0, 0] = "ITEM";
            equipamentos[0, 1] = "TIPO";
            equipamentos[0, 2] = "VALOR";
            equipamentos[0, 3] = "DANO";
            equipamentos[0, 4] = "DEFESA";
            equipamentos[0, 5] = "SLOTS";

            equipamentos[1, 0] = "Adaga";
            equipamentos[1, 1] = "Arma Branca";
            equipamentos[1, 2] = "10";
            equipamentos[1, 3] = "2";
            equipamentos[1, 4] = "0";
            equipamentos[1, 5] = "1";

            equipamentos[2, 0] = "Foice";
            equipamentos[2, 1] = "Arma Branca";
            equipamentos[2, 2] = "11";
            equipamentos[2, 3] = "3";
            equipamentos[2, 4] = "0";
            equipamentos[2, 5] = "1";

            equipamentos[3, 0] = "Espada";
            equipamentos[3, 1] = "Arma Branca";
            equipamentos[3, 2] = "12";
            equipamentos[3, 3] = "4";
            equipamentos[3, 4] = "0";
            equipamentos[3, 5] = "1";

            equipamentos[4, 0] = "Kunai";
            equipamentos[4, 1] = "Arma Branca";
            equipamentos[4, 2] = "8";
            equipamentos[4, 3] = "1";
            equipamentos[4, 4] = "0";
            equipamentos[4, 5] = "1";

            equipamentos[5, 0] = "Sniper";
            equipamentos[5, 1] = "Arma";
            equipamentos[5, 2] = "20";
            equipamentos[5, 3] = "100";
            equipamentos[5, 4] = "0";
            equipamentos[5, 5] = "1";

            equipamentos[6, 0] = "Pistola";
            equipamentos[6, 1] = "Arma";
            equipamentos[6, 2] = "9";
            equipamentos[6, 3] = "3";
            equipamentos[6, 4] = "0";
            equipamentos[6, 5] = "1";

            equipamentos[7, 0] = "Espingarda";
            equipamentos[7, 1] = "Arma";
            equipamentos[7, 2] = "15";
            equipamentos[7, 3] = "15";
            equipamentos[7, 4] = "0";
            equipamentos[7, 5] = "1";

            equipamentos[8, 0] = "Rifle de Assalto";
            equipamentos[8, 1] = "Arma";
            equipamentos[8, 2] = "15";
            equipamentos[8, 3] = "10";
            equipamentos[8, 4] = "0";
            equipamentos[8, 5] = "1";

            equipamentos[9, 0] = "Capacete";
            equipamentos[9, 1] = "Armadura";
            equipamentos[9, 2] = "10";
            equipamentos[9, 3] = "0";
            equipamentos[9, 4] = "5";
            equipamentos[9, 5] = "1";

            equipamentos[10, 0] = "Colete";
            equipamentos[10, 1] = "Armadura";
            equipamentos[10, 2] = "20";
            equipamentos[10, 3] = "0";
            equipamentos[10, 4] = "15";
            equipamentos[10, 5] = "1";

            equipamentos[11, 0] = "Calça de Ferro";
            equipamentos[11, 1] = "Armadura";
            equipamentos[11, 2] = "15";
            equipamentos[11, 3] = "0";
            equipamentos[11, 4] = "15";
            equipamentos[11, 5] = "1";

            equipamentos[12, 0] = "Bota";
            equipamentos[12, 1] = "Armadura";
            equipamentos[12, 2] = "10";
            equipamentos[12, 3] = "0";
            equipamentos[12, 4] = "5";
            equipamentos[12, 5] = "1";

            equipamentos[13, 0] = "Escudo";
            equipamentos[13, 1] = "Armadura Especial";
            equipamentos[13, 2] = "25";
            equipamentos[13, 3] = "0";
            equipamentos[13, 4] = "25";
            equipamentos[13, 5] = "1";

            equipamentos[14, 0] = "Granada";
            equipamentos[14, 1] = "Arma Especial";
            equipamentos[14, 2] = "5";
            equipamentos[14, 3] = "50";
            equipamentos[14, 4] = "0";
            equipamentos[14, 5] = "1";

            equipamentos[15, 0] = "Granada de Luz";
            equipamentos[15, 1] = "Arma Especial";
            equipamentos[15, 2] = "2";
            equipamentos[15, 3] = "1";
            equipamentos[15, 4] = "0";
            equipamentos[15, 5] = "1";

            equipamentos[16, 0] = "Cajado";
            equipamentos[16, 1] = "Arma Especial";
            equipamentos[16, 2] = "20";
            equipamentos[16, 3] = "25";
            equipamentos[16, 4] = "0";
            equipamentos[16, 5] = "1";

            equipamentos[17, 0] = "Missil Teleguiado";
            equipamentos[17, 1] = "Arma Ultra-Secret";
            equipamentos[17, 2] = "100";
            equipamentos[17, 3] = "200";
            equipamentos[17, 4] = "0";
            equipamentos[17, 5] = "1";

            equipamentos[18, 0] = "Poção Arremessável";
            equipamentos[18, 1] = "Arma Especial";
            equipamentos[18, 2] = "15";
            equipamentos[18, 3] = "15";
            equipamentos[18, 4] = "0";
            equipamentos[18, 5] = "1";

            equipamentos[19, 0] = "Arco e flecha";
            equipamentos[19, 1] = "Arma";
            equipamentos[19, 2] = "15";
            equipamentos[19, 3] = "15";
            equipamentos[19, 4] = "0";
            equipamentos[19, 5] = "1";

            equipamentos[20, 0] = "Lança";
            equipamentos[20, 1] = "Arma";
            equipamentos[20, 2] = "20";
            equipamentos[20, 3] = "25";
            equipamentos[20, 4] = "0";
            equipamentos[20, 5] = "1";

            listarItens();

        }
        public void listarItens()
        {
            Console.Clear();
            Console.WriteLine(equipamentos);
}
    }
}

