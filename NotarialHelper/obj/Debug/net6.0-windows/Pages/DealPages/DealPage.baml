   M S B A M L   `   `   `  ����I  ENotarialHelper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:NotarialHelper.PagesNotarialHelper.Pages  5      #    NotarialHelper.Pages.DealPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:NotarialHelper.Pages     5        N� Title$  DealPage��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      .+�5   
   c� $��0��6   $��14(�6   $��Bahnschrift SemiBold)�6-   .@�5      �� -   5         ��Name$ AddClientButton��5      .��6L   Записать6V   �� 5      �� 5      -   5        $ DeleteButton��5      .��6F   Удалить:6P   �� 5      �� 5      -   5        $ SearchButton��5      .��6+   Найти:63   �� 5      -   5         ��Name$ SearchTextBar��5      
�������$	��200��6D   6U   5      �� 5   
   $��1��6   ._�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 	DealsGrid��5         AutoGenerateColumns$
 True��6*      SelectionMode$ Single=�6F      RowBackground
 �����$��Bahnschrift Light)�5   -   $��20(�6L   $��Center=�6Z      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$		 №��6)   
   MinWidth$
 30Q�6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   ��  �� Path$ IdDeal�6T     5      $	 Клиент��6)   $	
 200Q�6]    69   �� $ 
NameClient�6]     5       $	 Услуга��6)   $	
 150Q�6^    69   �� $ NameService�6^     5!      $	 
Сумма��6)   $
 80Q�6Y    68   �� $ SumDeal�6Y     5"      $	 Комиссия��6)   $
 80Q�6b    6;   �� $ ComissionDeal�6b     5#      $	 Описание��6)   $	
 100Q�6`    6;   �� $ Description�6`   5%      5&      5(      5)      