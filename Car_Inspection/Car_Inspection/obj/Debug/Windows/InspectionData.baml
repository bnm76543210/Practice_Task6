   M S B A M L   `   `   `  ????I  ECar_Inspection, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Car_InspectionCar_Inspection  5   	   #    Car_Inspection.InspectionData   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Car_Inspection     5   	     ? Title$  InspectionData??5   	   $	??450??6    $	??800??6-   ???	#FFB8FF90$	??800??6P   $	??450??6_    ? WindowStartupLocation$ CenterScreen=?6o    ? Icon$ /car_logo.png??6?   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $	??80* ?6   ?? 5      $
??374* ?6   ?? 5      $	??60* ?6   .+?5   
   ?? $??Stretch=?6   ???	#FF44EF89$??Stretch=?6D   $??0??6`   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ Inspections??5      $??1??6(      AutoGenerateColumns .     
IsReadOnly .    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6c   $??Times New Roman)?6s   $
??Bold"?6?      CanUserReorderColumns .  	   CanUserResizeColumns	 .  
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$' !Номер тех. осмотра??6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   ?? *Inspection_id+4  .System.Windows.Controls.DataGridTemplateColumn  5      $! Код автомобиля??6)      CellTemplate 5      ?? 5      .R?5      ?? .+?5   "   ?? -   5        ???#0000??5   )   ?? *CarID+6V   5      5      5        5      $( "Код сотрудника ГАИ??6)    5      ?? 5       .R?5!      ?? .+?5"   "   ?? -   5        ???#0000??5"   )   ?? *	OfficerID+6Z   5#      5$      5&        5'      $ Дата осмотра??6%    6;   ?? *Inspection_date+  5(      $' !Результат осмотра??6%    6@   ?? *Result+  5)       5*      ?? 5+      .R?5,      ??  ??Name$ BtnInspectionEdit??6%   -   5        ???	#FF3ABAD8$ ??Редактировать??5,   W    ? 	Resources 5-   "    ?? 
TargetType ?? Property ?? Value??%_   '??       ?? 5.   &   " ??6,   .?5/   *   ??  ?@??CornerRadius$ 10??6I   50   '   51   #   52      53      55        56       57      ?? 58      .R?59      ?? $ BtnInspectionDelete??6%   -   5        ???	#FFD83A3A$??Удалить??59   Y    5:   "   ??%_   '??       ?? 5;   &   " ??6,   .?5<   *   ??  ?@??CornerRadius$ 10??6I   5=   '   5>   #   5?      5@      5B      5D      ?? 5F   
   $??Stretch=?6   ???	#FF44EF89$??Stretch=?6D   $??3??6`   ?? 5H   
   -   5        $ 
BackToMain??5H      $??
назад??6%   $??Center=?65   $??30??6P   $??90??6\   $??Times New Roman)?6g   $??18(?6?   $
??Bold"?6?   ???	#FF3ABAD8$??2??6?   $??0,0,20,0q?6?   $??Right=?6?    5I      ??%_   '??       ?? 5J      " ??6   .?5K      ??  ?@??CornerRadius$ 20??65   5L      5M      5N      ?? 5O   
   $
??Wrap=?6   $8??2СПИСОК ДАННЫХ ТЕХ. ОСМОТРОВ??6(   $??Times New Roman)?6K   $??24(?6h   $
??Bold"?6v    ?? TextAlignment$
 Left=?6?   $??Center=?6?   $??	50,0,50,0q?6?   $??30??6?   ?? 5P   
   -   5        $ BackToMain_Copy??5P      $#??Добавить запись??6*   $??Center=?6D   $??30??6_   $	??160??6k   $??Times New Roman)?6w   $??18(?6?   $
??Bold"?6?   ???	#FF3ABAD8$??2??6?   $??20,0,0,0q?6?   $
??Left=?6
   5Q      ??%_   '??       ?? 5R      " ??6   .?5S      ??  ?@??CornerRadius$ 20??65   5T      5U      5V      ?? 5W   
   -   5        $ BackToMain_Copy1??5W      $4??.Импортировать данные в pdf??6+   $??Center=?6P   $??30??6k   $	??260??6w   $??Times New Roman)?6?   $??18(?6?   $
??Bold"?6?   ???	#FF3ABAD8$??2??6?   $??Center=?6   5X      ??%_   '??       ?? 5Y      " ??6   .?5Z      ??  ?@??CornerRadius$ 20??65   5[      5\      5]      5^      5_      