using Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace Gestionnaire_de_tâche__Last_
{
    internal static class Project_to_Excel
    {
        /// <summary>
        /// TODO :
        /// Créer un fichier excel avec le projet, ces sous projets avec leur tâche.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="projet"></param>
        public static void createExcelFile(string path, Projet projet)
        {
            try
            {
                string totalPath = path + @"/" + projet.Nom_du_projet + ".xls";

                Application ExcelApp = new Application();
                Workbook ExcelWorkBook = null;
                Worksheet ExcelWorkSheet = null;
                ExcelWorkBook = ExcelApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
                ExcelWorkSheet = ExcelWorkBook.Worksheets[1]; // Le tableau dans lequel il y aura les données

                // COMMENCE PAR 1.1

                ExcelWorkSheet.Cells[1, 1] = projet.Nom_du_projet;
                ExcelWorkSheet.Range["A1"].Font.Size = 35;

                int nbTâche = 0;

                foreach (var sousProjet in projet.sous_Projets)
                {
                    foreach (var tache in sousProjet.Tâches)
                    {
                        nbTâche++;
                    }
                }

                ExcelWorkSheet.Cells[2, 1] = projet.sous_Projets.Count + " sous projet(s), " + nbTâche + " tâche(s).";

                List<int> actuallCell = new List<int>();
                actuallCell.Add(4); // Ligne
                actuallCell.Add(1); // Colonne

                // On écrit maintenant les sous projets avec leurs tâches
                foreach (var sousProj in projet.sous_Projets)
                {
                    // Écrit le nom du sous proj
                    ExcelWorkSheet.Cells[actuallCell[0], actuallCell[1]] = sousProj.Nom_du_sous_projet;

                    // Affiche le nombre de tâche dans le sous projet
                    ExcelWorkSheet.Cells[actuallCell[0], 9] = sousProj.Tâches.Count + " tâche(s)";
                    ExcelWorkSheet.Range["I" + actuallCell[0]].Font.Bold = true;
                    ExcelWorkSheet.Range["I" + actuallCell[0]].Font.Size = 15;

                    // Formate le nom du sous proj
                    ExcelWorkSheet.Range["A" + actuallCell[0]].Font.Bold = true;
                    ExcelWorkSheet.Range["A" + actuallCell[0]].Font.Color = sousProj.Couleur_du_sous_projet;
                    ExcelWorkSheet.Range["A" + actuallCell[0]].Font.Size = 18;

                    actuallCell[0]++;

                    // Haut du tableau
                    if (sousProj.Tâches.Count > 0)
                    {
                        ExcelWorkSheet.Range["A" + actuallCell[0] + ":H" + actuallCell[0]].Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
                        ExcelWorkSheet.Range["I" + actuallCell[0]].Borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;

                        ExcelWorkSheet.Cells[actuallCell[0], actuallCell[1]] = "                                                 Nom de la tâche";
                        ExcelWorkSheet.Cells[actuallCell[0], 6] = "État";
                        ExcelWorkSheet.Cells[actuallCell[0], 7] = "Priorité";
                        ExcelWorkSheet.Cells[actuallCell[0], 8] = "Date";
                        ExcelWorkSheet.Range["F" + actuallCell[0]].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        ExcelWorkSheet.Range["H" + actuallCell[0]].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        ExcelWorkSheet.Range["G" + actuallCell[0]].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                        actuallCell[0]++;

                        ExcelWorkSheet.Range["A" + actuallCell[0] + ":H" + actuallCell[0]].Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
                    }

                    // Affiche les tâches
                    foreach (var tache in sousProj.Tâches)
                    {
                        // Nom
                        ExcelWorkSheet.Cells[actuallCell[0], actuallCell[1]] = tache.Nom_de_la_tâche;
                        ExcelWorkSheet.Range["A" + actuallCell[0]].Font.Size = 15;

                        // Etat
                        ExcelWorkSheet.Cells[actuallCell[0], 6] = Main.Utilities.resource.etats[tache.State_de_la_tâche].Texte_de_l_etat;
                        ExcelWorkSheet.Range["F" + actuallCell[0]].Font.Size = 13;
                        // Couleur de l'état
                        ExcelWorkSheet.Range["F" + actuallCell[0]].Interior.Color = Main.Utilities.resource.etats[tache.State_de_la_tâche].Couleur_de_l_etat;
                        // Centre l'état
                        ExcelWorkSheet.Range["F" + actuallCell[0]].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        // Barrière gauche pour avoir un effet de tableau
                        ExcelWorkSheet.Range["F" + actuallCell[0]].Borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;

                        // Priorité
                        ExcelWorkSheet.Cells[actuallCell[0], 7] = Main.Utilities.resource.priorités[tache.Priorité_de_la_tâche].Texte_de_l_etat;
                        ExcelWorkSheet.Range["G" + actuallCell[0]].Font.Size = 13;
                        // Couleur de l'état
                        ExcelWorkSheet.Range["G" + actuallCell[0]].Interior.Color = Main.Utilities.resource.priorités[tache.Priorité_de_la_tâche].Couleur_de_l_etat;
                        // Centre l'état
                        ExcelWorkSheet.Range["G" + actuallCell[0]].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        // Barrière gauche pour avoir un effet de tableau
                        ExcelWorkSheet.Range["G" + actuallCell[0]].Borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;

                        // Date d'échéance
                        if (tache.Date_d_echeance != null)
                        {
                            TextInfo myTI = new CultureInfo("fr-FR", false).TextInfo;

                            ExcelWorkSheet.Cells[actuallCell[0], 8] = tache.Date_d_echeance.Value.Day.ToString().PadLeft(1, '0') + " " + myTI.ToTitleCase(tache.Date_d_echeance.Value.ToString("MMMM", new CultureInfo("fr-FR")));
                            ExcelWorkSheet.Range["H" + actuallCell[0]].Font.Size = 13;
                            ExcelWorkSheet.Range["H" + actuallCell[0]].Font.Strikethrough = true;
                            ExcelWorkSheet.Range["H" + actuallCell[0]].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                            ExcelWorkSheet.Range["H" + actuallCell[0]].Borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
                            ExcelWorkSheet.Range["H" + actuallCell[0]].Borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
                        }
                        else
                        {
                            // On met quand même une bordure
                            ExcelWorkSheet.Range["H" + actuallCell[0]].Borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
                            ExcelWorkSheet.Range["H" + actuallCell[0]].Borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
                        }

                        actuallCell[0]++;
                    }

                    // Bas du tableau
                    if (sousProj.Tâches.Count > 0)
                    {
                        ExcelWorkSheet.Range["A" + actuallCell[0] + ":H" + actuallCell[0]].Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
                    }

                    actuallCell[0]++;
                    actuallCell[0]++;
                }

                ExcelWorkBook.Worksheets[1].Name = projet.Nom_du_projet;
                ExcelApp.Visible = true;

                ExcelWorkBook.SaveAs(totalPath);
                //ExcelWorkBook.Close();
                //ExcelApp.Quit();

                Marshal.ReleaseComObject(ExcelWorkSheet);
                Marshal.ReleaseComObject(ExcelWorkBook);
                Marshal.ReleaseComObject(ExcelApp);

            }
            catch
            {
                MessageBox.Show("Il semblerait y avoir un problème. Veuillez réessayer jusqu'au résultat attendu !\n",
                    "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}