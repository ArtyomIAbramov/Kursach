   M S B A M L   `   `   `  ����D  @AutoSalon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:AutoSalon.ViewsAutoSalon.Views  5   	   (    "AutoSalon.Views.SelectEmployeeView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:AutoSalon.Views     5   	     � Title$  SelectEmployeeView��5   	   $	��450��6$   $	��850��61   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid     AutoGenerateColumns .     
IsReadOnly .    SelectionMode$ Single=�6�      SelectionUnit$ FullRow=�6�   $	��Top=�6�   $��Center=�6�   $	��800��6�   $	��430��6  ��6/   �� *	Employees+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$  ��6<   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 0 6F   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6%   �� *Id+6F     5      $ Имя��6>   $	 80 6K   
 6%   �� *Name+6K     5      $ Должность��6>   $		 110 6Q   
 6%   �� *Post+6Q     5      $ Телефон��6H   $	 90 6Y   
 6%   �� *Empphonenumber+6Y     5      $ 
Адрес��6D   $		 100 6S   
 6%   �� *
Empaddress+6S     5      $ Паспорт��6E   $	 90 6V   
 6%   �� *Emppassport+6V     5      $ Email��6?   $	 90 6N   
 6%   �� *Email+6N   4  .System.Windows.Controls.DataGridTemplateColumn  5      $		 200 6)      CellTemplate 5      �� 5      .R�5      �� $��Выбрать��6%   ��67   ��  �� Path$ Id���5   )   �� $' !DataContext.ChooseEmployeeCommand� �� RelativeSource �� *FindAncestor+ �� AncestorType$ WindowL�5      5      5      5      5      