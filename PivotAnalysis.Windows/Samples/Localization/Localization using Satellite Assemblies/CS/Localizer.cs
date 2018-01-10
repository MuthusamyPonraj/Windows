#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.PivotAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication11
{
    class Localizer : ILocalizationProvider
    {
        public string GetLocalizedString(System.Globalization.CultureInfo culture, string name, object obj)
        {
            switch (name)
            {
                case PivotResourceIdentifiers.PivotTableFieldList:
                    return "Pivot Tablie Feld liste";
                case PivotResourceIdentifiers.Choosefieldstoaddreport:
                    return "Wählen Sie die Felder, um Bericht hinzufügen";
                case PivotResourceIdentifiers.ColumnLabels:
                    return "Spalte";
                case PivotResourceIdentifiers.DeferlayoutUpdate:
                    return "Verschieben Layoute";
                case PivotResourceIdentifiers.Dragfieldsbetweenareasbelow:
                    return "Ziehen Sie die Felder zwischen Flächen unter";
                case PivotResourceIdentifiers.DropPivotFieldsheretoFilterBy:
                    return "Schau hier, um Pivot Felder durch Filter";
                case PivotResourceIdentifiers.MoveDown:
                    return "Nach unten";
                case PivotResourceIdentifiers.MoveToBeginning:
                    return "An den Anfang";
                case PivotResourceIdentifiers.MoveToColumnLabels:
                    return "Spaltenbeschriftungen";
                case PivotResourceIdentifiers.MoveToEnd:
                    return "Zum Ende";
                case PivotResourceIdentifiers.MoveToReportFilter:
                    return "Verschieben nach Filter melden";
                case PivotResourceIdentifiers.MoveToRowLabels:
                    return "Verschieben nach Etikettenzeile";
                case PivotResourceIdentifiers.MoveToValues:
                    return "Bewegen Sie die Werte";

                case PivotResourceIdentifiers.MoveUp:
                    return "Nach oben";
                case PivotResourceIdentifiers.OK:
                    return "OK";
                case PivotResourceIdentifiers.PivotSchemaDesigner:
                    return "Pivot Svhemae Konstrukteur";
                case PivotResourceIdentifiers.RemoveField:
                    return "Feld entfernen";
                case PivotResourceIdentifiers.ReportFilter:
                    return "Berichtsfilter";
                case PivotResourceIdentifiers.RowLabel:
                    return "Reihe Etikett";
                case PivotResourceIdentifiers.ShowCalculationsasColumns:
                    return "Die Berechnungen zeigen, wie Spalten";
                case PivotResourceIdentifiers.Update:
                    return "Aktualisierung";
                case PivotResourceIdentifiers.Values:
                    return "Werte";
                default:
                    return string.Empty;

            }
         
        }
    }
}