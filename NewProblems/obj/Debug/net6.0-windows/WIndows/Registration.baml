   M S B A M L   `   `   `  ����F  BNewProblems, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:NewProblemsNewProblems  5   	       NewProblems.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:NewProblems     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6   � 5      $ 	#FF3A3838��6    � Offset$ 1Q�61   5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ UsersdataGrid��5      $��180,28,180,187q�6*   ���	#FF8C8C8C���	#FF1B1B1B   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6q    � ContextMenu 5      �� 5      .@�5      m� -   5        $��Delete��5      6/   m� 5      -   5        $��Update��5      6/   5         Columns 5      5      �� 5   
   -   5        	 ��Name$	 add_btn��5      $	��Add��6"   $��Center=�60   $��	0,252,0,0q�6M   $	��Top=�6`   $��41��6x   $	��200��6�   6�   �� 5   
   -   5        $	 clearing_btn��5      $��	ClearTxts��6'   $
��Left=�6;   $��465,338,0,0q�6V   $	��Top=�6k   $��41��6�   $��57��6�   6�   �� 5   
   -   5        
 ��Name$
 	login_txt��5      $
��Left=�6%   $��266,315,0,0q�6@    �� TextWrapping$
 Wrap=�6U   $�� ��6i   $	��Top=�6q   $	��120��6�   �� 5   
   -   5        $
 password_txt��5      $
��Left=�6(   $��424,315,0,0q�6C   $
 Wrap=�6X   $�� ��6l   $	��Top=�6t   $	��120��6�   �� 5    
   -   5         ��Name$ 	combo_box��5       $��Center=�6&   $��	0,338,0,0q�6C   $	��Top=�6V   $	��120��6n   .@�5!      �� $��Administrator��6   �� 5"      $��Coach��6   �� 5#      $��Buyer��6   5$      �� 5%   
   -	   5        $��Return��5%      $��Center=�6"   $��	0,388,0,0q�6?   $	��Top=�6R   6j   �� 5&   
   -
   5         ��Name$ login_label��5&      $��Login��6%   $
��Left=�65   $��222,311,0,0q�6P   $	��Top=�6e   
�������6}   �� 5'   
   -   5        $ password_label��5'      $��Password��6(   $
��Left=�6;   $��544,311,0,0q�6V   $	��Top=�6k   
�������6�   5(      5)      