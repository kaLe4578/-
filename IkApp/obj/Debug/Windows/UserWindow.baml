   M S B A M L   `   `   `  ����@  <IkApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:IkApp.WindowsIkApp.Windows  5   	       IkApp.Windows.UserWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:IkApp.Windows     5   	     � Title$  
UserWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� $
��Left=�6   $	��419��60   $	��Top=�6=   $	��790��6U   .@�5      �� $��
Книги��6   $��	0,0,-2,-9q�6%   $��29��68   $	��Top=�6D   $��15(�6\   .��5      � ���	#FFE5E5E5$��	0,-27,0,0q�6.    � RowDefinitions 5      �� 5      $��0* �6(   �� 5      .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ datagrid��5      $
��Left=�61   $	��364��6L   $��0,35,0,0q�6Y   $��2��6k   $	��Top=�6|   $	��615��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 №��61      Width5  /System.Windows.Controls.DataGridLengthConverter$ 28 6d   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *KodInventarnoyKnigi+6q     5      $ 
Автор��61   $ 51 6[    6@   �� *Author+6h     5      $ Название��61   $ 75 6\    6C   �� *Name+6i     5      $ Место издания��61   $	 113 6j    6H   �� *MestoIzdaniya+6x     5      $ Год издания��61   $ 95 6\    6F   �� *с+6i     5      $D >Раздел систематического каталога��61   $ * 6�    6[   �� *!RazdelSistematicheskogoKataloga+6�   5      �� 5      -   5        $��Бронировать��5      $
��Left=�63   $��620,275,0,0q�6N   $��2��6c   $	��Top=�6t   $	��156��6�   $��40��6�   $��22(�6�   6�   �� 5      -   5        $��
Выход��5      $
��Left=�6-   $��620,342,0,0q�6H   $��2��6]   $	��Top=�6n   $	��156��6�   $��40��6�   $��22(�6�   6�   �� 5      $
��Left=�6   $��30��69   $��	442,0,0,0q�6E   $��2��6X    �� TextWrapping$
 Wrap=�6i   $�� ��6}   $	��Top=�6�   $	��334��6�   �� 5      $��
Поиск��6   $
��Left=�6,   $��
354,-9,0,0q�6G   $��2��6[   $	��Top=�6l   $	��156��6�   $��22(�6�   5      5       5!      5"      5#      