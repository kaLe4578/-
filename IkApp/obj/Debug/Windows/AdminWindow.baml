   M S B A M L   `   `   `  ����@  <IkApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:IkApp.WindowsIkApp.Windows  5   	       IkApp.Windows.AdminWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:IkApp.Windows     5   	     � Title$  AdminWindow��5   	   $	��450��6   $	��800��6*   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ datagrid��5
      $
��Left=�6%   $	��419��6@   $	��Top=�6M   $	��600��6e      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Логин��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6N   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *Login+6[     5      $ Пароль��6%   $ * 6R    65   �� *
Password+6^   5      �� 5   
   -   5         ��Name$
 Exit��5      $��
Выход��6   $
��Left=�6/   $��615,360,0,0q�6J   $	��Top=�6_   $	��167��6w   $��48��6�   6�   �� 5   
   -   5        $ Block��5      $��Блокировать��6    $
��Left=�66   $��615,290,0,0q�6Q   $	��Top=�6f   $	��167��6~   $��48��6�   6�   �� 5   
   -   5        $
 Edit��5      $��Изменить��6   $
��Left=�62   $��615,144,0,0q�6M   $	��Top=�6b   $	��167��6z   $��48��6�   6�   �� 5   
   -   5        $	 Add��5      $��Добавить��6   $
��Left=�61   $��
615,68,0,0q�6L   $	��Top=�6`   $	��167��6x   $��48��6�   6�   �� 5   
   -   5        $ Abdeit��5      $��Обновить��6!   $
��Left=�64   $��615,221,0,0q�6O   $	��Top=�6d   $	��167��6|   $��48��6�   6�   5      5      