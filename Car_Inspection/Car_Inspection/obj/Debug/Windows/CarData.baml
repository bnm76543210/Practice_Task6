   M S B A M L   `   `   `  ????I  ECar_Inspection, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Car_InspectionCar_Inspection  5   	       Car_Inspection.CarData   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Car_Inspection     5   	     ? Title$  CarData??5   	   $	??450??6   $	??800??6&   ???	#FFB8FF90$	??800??6I   $	??450??6X    ? Icon$ /car_logo.png??6h    ? WindowStartupLocation$ CenterScreen=?6}   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $	??80* ?6   ?? 5      $
??374* ?6   ?? 5      $	??60* ?6   .+?5   
   ?? $??Stretch=?6   ???	#FF44EF89$??Stretch=?6D   $??0??6`   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ CarDataGrid??5      $??1??6(      AutoGenerateColumns .     
IsReadOnly .    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6c   $??Times New Roman)?6s   $
??Bold"?6?      CanUserReorderColumns .  	   CanUserResizeColumns	 .  
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$! Код автомобиля??6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   ?? *Car_id+  5      $ Гос. номер??6%    69   ?? *State_number+  5      $# Номер двигателя??6%    6>   ?? *Engine_number+  5      $ Цвет??6%    63   ?? *Color+  5      $ 
Марка??6%    64   ?? *Brand+  5      $) #Номер тех. паспорта??6%    6B   ?? *Number_of_passport+4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Код владельца??6)      CellTemplate 5      ?? 5      .R?5      ?? .+?5   "   ?? -   5        ???#0000??5   )   ?? *	OwnerID+6X   5      5      5!      5#      ?? 5%   
   $??Stretch=?6   ???	#FF44EF89$??Stretch=?6D   $??3??6`   ?? 5&   
   -   5         ??Name$ 
BackToMain??5&      $??
назад??6%   $??Center=?65   $??30??6P   $??90??6\   $??Times New Roman)?6g   $??18(?6?   $
??Bold"?6?   ???	#FF3ABAD8$??2??6?   $??0,0,20,0q?6?   $??Right=?6?    ? 	Resources 5'       ?? 
TargetType ?? Property ?? Value??%_   '??       ?? 5(      " ??6   .?5)      ??  ?@??CornerRadius$ 20??65   5*      5+      5,      ?? 5-   
   $
??Wrap=?6   $6??0СПИСОК ДАННЫХ АВТОМОБИЛЕЙ??6(   $??Times New Roman)?6I   $??24(?6f   $
??Bold"?6t    ?? TextAlignment$
 Left=?6?   $??Center=?6?   $??	50,0,50,0q?6?   $??30??6?   5.      5/      