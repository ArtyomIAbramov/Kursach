   M S B A M L   `   `   `  ����D  @AutoSalon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:AutoSalon.ViewsAutoSalon.Views  5   	       AutoSalon.Views.PriceList   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:AutoSalon.Views     5   	     � Title$  	PriceList��5   	   $	��450��6   $	��700��6(    � 	Resources 5
         
TitleStyle �� 
TargetType �� Property �� Value��%�   &	        �� 5   
   " ��6#   .�5      ��  � ��$ 
Montserrat)�6+   �� 5       � ��$ 24(�6)   �� 5       � ��$
 Bold"�6+   �� 5       � �� �#1f08546+   5      5      .��5      �� .+�5   
   �� $��Center=�6   #��[  61   $��	0,20,0,20q�6U   $
��Wrap=�6h   $��Прайс лист��6|   $	��Top=�6�   &   System.Windows.Controls.DataGrid  5   
      AutoGenerateColumns .     
IsReadOnly .    SelectionMode$ Single=�6�      SelectionUnit$ FullRow=�6�   $	��Top=�6�   $��Center=�6�   $	��650��6   $	��350��6  ��6/   �� *Cars_in_shop_list+	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$  ��6<      Width5  /System.Windows.Controls.DataGridLengthConverter$ 0 6F   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Id+6F     5      $ 
Марка��6B   $	 100 6Q    6%   �� *
BrandNew+6Q     5      $ Модель��6?   $	 100 6O    6%   �� *Model+6O     5      $ Цвет��6?   $ 90 6M    6%   �� *Color+6M     5      $ Цена��6>   $ 90 6L    6%   �� *Cost+6L     5      $ Макс.скорость��6C   $	 130 6Z    6%   �� *	Max_speed+6Z     5      $ Мощность��6?   $	 100 6Q    6%   �� *Power+6Q   5      5       5!      