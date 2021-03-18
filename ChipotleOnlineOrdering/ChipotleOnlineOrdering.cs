using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChipotleOnlineOrdering
{
    public partial class ChipotleOnlineOrdering : Form
    {
        public ChipotleOnlineOrdering()
        {
            InitializeComponent();

        }

        //Filling Variables
        decimal fillingCrnAsda = 8.50m;
        decimal fillingStkBarb = 8.00m;
        decimal fillingCarnitas = 7.50m;
        decimal fillingChickSofVeg = 6.95m;

        decimal xtrPortionCrnAsda = 3.55m;
        decimal xtrPortionStkBarb = 3.35m;
        decimal xtrPortionCarnitas = 2.85m;
        decimal xtrPortionChickSofVeg = 2.35m;

        //Side Topping Variables
        decimal chips = 1.40m;
        decimal quesoTop = 1.25m;
        decimal guacQueso = 2.05m;
        decimal lrgChpGuac = 5.75m;
        decimal lrgChpQueso = 5.25m;
        decimal chpsSalsa = 2.05m;

        //Drink Variables
        decimal soda22oz = 1.95m;
        decimal soda32oz = 2.20m;
        decimal btlWater = 2.45m;
        decimal sprkWater = 2.65m;
        decimal glsBtlJuiceSoda = 2.80m;

        //Receipt Text Variables
        string orderReceipt = "";
        

        //Cost Variables
        decimal subtotal = 0m;
        decimal taxPercent = 0.0676m;
        decimal taxTotal = 0m;

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            orderReceipt = "";
            subtotal = 0m;
            taxPercent = 0.0676m;
            taxTotal = 0m;

            //Type Options
            if (radBurrito.Checked)
            {
                orderReceipt += "Burrito: ";
            }
            else if (radBurritoBowl.Checked)
            {
                orderReceipt += "Burrito Bowl: ";
            }
            else if (radTaco.Checked)
            {
                orderReceipt += "3x Tacos: ";
            }
            else if (radSalad.Checked)
            {
                orderReceipt += "Salad:\t";
            }

            //Filling Options
            if (radCarneAsada.Checked)
            {
                subtotal += fillingCrnAsda;
                orderReceipt += "Carne Asada\t\t $" + fillingCrnAsda + "\n";
                
                if (chkExtraPortions.Checked)
                {
                    subtotal += xtrPortionCrnAsda;
                    orderReceipt += "\textra portion\t\t+$" + xtrPortionCrnAsda + "\n";
                }
            }
            else if (radBarbacoa.Checked)
            {
                subtotal += fillingStkBarb;
                orderReceipt += "Barbacoa\t\t $" + fillingStkBarb + "\n";

                if (chkExtraPortions.Checked)
                {
                    subtotal += xtrPortionStkBarb;
                    orderReceipt += "\textra portion\t\t+$" + xtrPortionStkBarb + "\n";
                }
            }
            else if (radSteak.Checked)
            {
                subtotal += fillingStkBarb;
                orderReceipt += "Steak\t\t $" + fillingStkBarb + "\n";

                if (chkExtraPortions.Checked)
                {
                    subtotal += xtrPortionStkBarb;
                    orderReceipt += "\textra portion\t\t+$" + xtrPortionStkBarb + "\n";
                }
            }
            else if (radCarnitas.Checked)
            {
                subtotal += fillingCarnitas;
                orderReceipt += "Carnitas\t\t $" + fillingCarnitas + "\n";

                if (chkExtraPortions.Checked)
                {
                    subtotal += xtrPortionCarnitas;
                    orderReceipt += "\textra portion\t\t+$" + xtrPortionCarnitas + "\n";
                }
            }
            else if (radChicken.Checked)
            {
                subtotal += fillingChickSofVeg;
                orderReceipt += "Chicken\t\t $" + fillingChickSofVeg + "\n";

                if (chkExtraPortions.Checked)
                {
                    subtotal += xtrPortionChickSofVeg;
                    orderReceipt += "\textra portion\t\t+$" + xtrPortionChickSofVeg + "\n";
                }
            }
            else if (radSofritas.Checked)
            {
                subtotal += fillingChickSofVeg;
                orderReceipt += "Sofritas\t\t $" + fillingChickSofVeg + "\n";

                if (chkExtraPortions.Checked)
                {
                    subtotal += xtrPortionChickSofVeg;
                    orderReceipt += "\textra portion\t\t+$" + xtrPortionChickSofVeg + "\n";
                }
            }
            else if (radVeggie.Checked)
            {
                //There are no extra portion options for veggie
                subtotal += fillingChickSofVeg;
                orderReceipt += "Veggie\t\t $" + fillingChickSofVeg + "\n";
            }

            //Rice
            if (chkWhiteRice.Checked)
            {
                orderReceipt += "\tWhite Rice\n";
            }
            if (chkBrownRice.Checked)
            {
                orderReceipt += "\tBrown Rice\n";
            }

            //Beans
            if (chkBlackBeans.Checked)
            {
                orderReceipt += "\tBlack Beans\n";
            }
            if (chkPintoBeans.Checked)
            {
                orderReceipt += "\tPinto Beans\n";
            }

            //Toppings
            if (chkQueso.Checked)
            {
                subtotal += quesoTop;
                orderReceipt += "\tQueso\t\t\t+$" + quesoTop + "\n";
            }
            if (chkGuac.Checked)
            {
                subtotal += guacQueso;
                orderReceipt += "\tGuacamole\t\t+$" + guacQueso + "\n";
            }
            if (chkTomatoSalsa.Checked)
            {
                orderReceipt += "\tFresh Tomato Salsa\n";
            }
            if (chkChiliCornSalsa.Checked)
            {
                orderReceipt += "\tRoasted Chili-Corn Salse\n";
            }
            if (chkGreenChiliSalsa.Checked)
            {
                orderReceipt += "\tTomatillo-Green Chili Salsa\n";
            }
            if (chkRedChiliSalsa.Checked)
            {
                orderReceipt += "\tTomatillo-Red Chili Salsa\n";
            }
            if (chkSourCream.Checked)
            {
                orderReceipt += "\tSour Cream\n";
            }
            if (chkFajitaVeggies.Checked)
            {
                orderReceipt += "\tFajita Veggies\n";
            }
            if (chkCheese.Checked)
            {
                orderReceipt += "\tCheese\n";
            }
            if (chkRomaineLettuce.Checked)
            {
                orderReceipt += "\tRomaine Lettuce\n";
            }

            //Side Options
            if (numUpDownChips.Value > 0)
            {
                subtotal += chips * numUpDownChips.Value;
                orderReceipt += numUpDownChips.Value + "x Chips\t\t\t\t+$" + (chips * numUpDownChips.Value) + "\n";
            }
            if (numUpDownChipsNGuac.Value > 0)
            {
                subtotal += (chips + guacQueso) * numUpDownChipsNGuac.Value;
                orderReceipt += numUpDownChipsNGuac.Value + "x Chips & Guac\t\t\t+$" + ((chips + guacQueso) * numUpDownChipsNGuac.Value) + "\n";
            }
            if (numUpDownLrgChipsNLrgGuac.Value > 0)
            {
                subtotal += lrgChpGuac * numUpDownLrgChipsNLrgGuac.Value;
                orderReceipt += numUpDownLrgChipsNLrgGuac.Value + "x Lrg Chips & Lrg Guac\t\t+$" + (lrgChpGuac * numUpDownLrgChipsNLrgGuac.Value) + "\n";
            }
            if (numUpDownSideOfGuac.Value > 0)
            {
                subtotal += guacQueso * numUpDownSideOfGuac.Value;
                orderReceipt += numUpDownSideOfGuac.Value + "x Side of Guacamole\t\t+$" + (guacQueso * numUpDownSideOfGuac.Value) + "\n";
            }
            if (numUpDownChipsNQueso.Value > 0)
            {
                subtotal += (chips + guacQueso) * numUpDownChipsNQueso.Value;
                orderReceipt += numUpDownChipsNQueso.Value + "x Chips & Queso\t\t\t+$" + ((chips + guacQueso) * numUpDownChipsNQueso.Value) + "\n";
            }
            if (numUpDownLrgChipsNLrgQueso.Value > 0)
            {
                subtotal += lrgChpQueso * numUpDownLrgChipsNLrgQueso.Value;
                orderReceipt += numUpDownLrgChipsNLrgQueso.Value + "x Lrg Chips & Lrg Queso\t\t+$" + (lrgChpQueso * numUpDownLrgChipsNLrgQueso.Value) + "\n";
            }
            if (numUpDownSideOfQueso.Value > 0)
            {
                subtotal += guacQueso * numUpDownSideOfQueso.Value;
                orderReceipt += numUpDownSideOfQueso.Value + "x Side of Queso\t\t\t+$" + (guacQueso * numUpDownSideOfQueso.Value) + "\n";
            }
            if (numUpDownChipsNTomatoSalsa.Value > 0)
            {
                subtotal += chpsSalsa * numUpDownChipsNTomatoSalsa.Value;
                orderReceipt += numUpDownChipsNTomatoSalsa.Value + "x Chips & Fresh Tomato Salsa\t+$" + (chpsSalsa * numUpDownChipsNTomatoSalsa.Value) + "\n";
            }
            if (numUpDownChipsNRedChiliSalsa.Value > 0)
            {
                subtotal += chpsSalsa * numUpDownChipsNRedChiliSalsa.Value;
                orderReceipt += numUpDownChipsNRedChiliSalsa.Value + "x Chips & Tomatillo-Red Chili Salsa\t+$" + (chpsSalsa * numUpDownChipsNRedChiliSalsa.Value) + "\n";
            }
            if (numUpDownChipsNGreenChiliSalsa.Value > 0)
            {
                subtotal += chpsSalsa * numUpDownChipsNGreenChiliSalsa.Value;
                orderReceipt += numUpDownChipsNGreenChiliSalsa.Value + "x Chips & Tomatillo-Green Chili Salsa\t+$" + (chpsSalsa * numUpDownChipsNGreenChiliSalsa.Value) + "\n";
            }
            if (numUpDownChipsNChiliCornSalsa.Value > 0)
            {
                subtotal += chpsSalsa * numUpDownChipsNChiliCornSalsa.Value;
                orderReceipt += numUpDownChipsNChiliCornSalsa.Value + "x Chips & Roasted Chili-Corn Salsa\t+$" + (chpsSalsa * numUpDownChipsNChiliCornSalsa.Value) + "\n";
            }

            //Drink Options
            if (numUpDown22ozSoda.Value > 0)
            {
                subtotal += (soda22oz * numUpDown22ozSoda.Value);
                orderReceipt += numUpDown22ozSoda.Value + "x 22oz Soda/Tea\t\t\t+$" + (soda22oz * numUpDown22ozSoda.Value) + "\n";
                taxTotal += (soda22oz * numUpDown22ozSoda.Value) * taxPercent;
            }
            if (numUpDown32ozSoda.Value > 0)
            {
                subtotal += (soda32oz * numUpDown32ozSoda.Value);
                orderReceipt += numUpDown32ozSoda.Value + "x 32oz Soda/Tea\t\t\t+$" + (soda32oz * numUpDown32ozSoda.Value) + "\n";
                taxTotal += (soda32oz * numUpDown32ozSoda.Value) * taxPercent;
            }
            if (numUpDownMexicanCocaCola.Value > 0)
            {
                subtotal += (glsBtlJuiceSoda * numUpDownMexicanCocaCola.Value);
                orderReceipt += numUpDownMexicanCocaCola.Value + "x Mexican Coca Cola\t\t+$" + (glsBtlJuiceSoda * numUpDownMexicanCocaCola.Value) + "\n";
                taxTotal += (glsBtlJuiceSoda * numUpDownMexicanCocaCola.Value) * taxPercent;
            }
            if (numUpDownSanPellegino.Value > 0)
            {
                subtotal += (sprkWater * numUpDownSanPellegino.Value);
                orderReceipt += numUpDownSanPellegino.Value + "x San Pellegrino Sprk Water\t\t+$" + (sprkWater * numUpDownSanPellegino.Value) + "\n";
            }
            if (numUpDownBlackberry.Value > 0)
            {
                subtotal += (glsBtlJuiceSoda * numUpDownBlackberry.Value);
                orderReceipt += numUpDownBlackberry.Value + "x Blackberry\t\t\t+$" + (glsBtlJuiceSoda * numUpDownBlackberry.Value) + "\n";
            }
            if (numUpDownGrapefruit.Value > 0)
            {
                subtotal += (glsBtlJuiceSoda * numUpDownGrapefruit.Value);
                orderReceipt += numUpDownGrapefruit.Value + "x Grapefruit\t\t\t+$" + (glsBtlJuiceSoda * numUpDownGrapefruit.Value) + "\n";
            }
            if (numUpDownClementine.Value > 0)
            {
                subtotal += (glsBtlJuiceSoda * numUpDownClementine.Value);
                orderReceipt += numUpDownClementine.Value + "x Clementine\t\t\t+$" + (glsBtlJuiceSoda * numUpDownClementine.Value) + "\n";
            }
            if (numUpDownBottledWater.Value > 0)
            {
                subtotal += (btlWater * numUpDownBottledWater.Value);
                orderReceipt += numUpDownBottledWater.Value + "x Bottled Water\t\t\t+$" + (btlWater * numUpDownBottledWater.Value) + "\n";
            }
            if (numUpDownApple.Value > 0)
            {
                subtotal += (glsBtlJuiceSoda * numUpDownApple.Value);
                orderReceipt += numUpDownApple.Value + "x Apple\t\t\t\t+$" + (glsBtlJuiceSoda * numUpDownPineappleOrangeBanana.Value) + "\n";
            }
            if (numUpDownPeachOrange.Value > 0)
            {
                subtotal += (glsBtlJuiceSoda * numUpDownPeachOrange.Value);
                orderReceipt += numUpDownPeachOrange.Value + "x Peach Orange\t\t\t+$" + (glsBtlJuiceSoda * numUpDownPineappleOrangeBanana.Value) + "\n";
            }
            if (numUpDownPineappleOrangeBanana.Value > 0)
            {
                subtotal += (glsBtlJuiceSoda * numUpDownPineappleOrangeBanana.Value);
                orderReceipt += numUpDownPineappleOrangeBanana.Value + "x Pineapple Orange Banana\t\t+$" + (glsBtlJuiceSoda * numUpDownPineappleOrangeBanana.Value) + "\n";
            }
            if (numUpDownPomegranateCherry.Value > 0)
            {
                subtotal += (glsBtlJuiceSoda * numUpDownPomegranateCherry.Value);
                orderReceipt += numUpDownPomegranateCherry.Value + "x Pomegranate Cherry\t\t+$" + (glsBtlJuiceSoda * numUpDownPomegranateCherry.Value) + "\n";
            }


            txtSubtotal.Text = Convert.ToString(subtotal);
            txtTax.Text = Convert.ToString(Math.Round(taxTotal, 2));
            txtTotal.Text = Convert.ToString(Math.Round((subtotal + taxTotal), 2));
            rTxtOrder.Text = orderReceipt;


        }

        private void BtnReset_Click(object sender, EventArgs e)
        {

        }

        private void BtnCheckOut_Click(object sender, EventArgs e)
        {

        }

        private void RadVeggie_CheckedChanged(object sender, EventArgs e)
        {
            if (radVeggie.Checked)
            {
                chkExtraPortions.Enabled = false;
                chkExtraPortions.Checked = false;
            }
            if (!radVeggie.Checked)
            {
                chkExtraPortions.Enabled = true;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
