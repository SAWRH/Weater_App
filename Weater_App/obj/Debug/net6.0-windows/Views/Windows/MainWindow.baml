   M S B A M L   `   `   `  ����@  <MVVM4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:MVVM4.ViewModelsMVVM4.ViewModels  5   	   clr-namespace:MVVM4MVVM4  5   	       MVVM4.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -vmclr-namespace:MVVM4.ViewModels     5   	   %localclr-namespace:MVVM4     5   	     � Title$  Weather Forecast��5	   	   $	��450��6"   $	��800��6/    � DataContext 5      *  $MVVM4.ViewModels.MainWindowViewModel  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��0��6   $��4��6"    �� Orientation$ Vertical=�68   .+�5      �� $��Center=�6   $ 
Horizontal=�67   .+�5      ��  �� AcceptsReturn$
 True��6O   $	��200��6e   $��0,0,30,0q�6q   $��30��6�   $��16(�6�   ��6   �� *City+ �� UpdateSourceTrigger$ PropertyChanged=�.��6�   ��5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   5   �� 6   6sys&clr-namespace:System;assembly=mscorlib     65    �� 
TargetType" ��6     �� 	Resources 5          CueBannerBrush	 j� 
AlignmentX
 j� 
AlignmentY j� Stretch !� Visual��%�   &	        !� 5!   "   $
	 Left=�6E   $
 Center=�6W   $
 None=�6k    5"   &   �� 5#   *   $��Search��60   
�������6A   5%   #   5&       �� Triggers 5'      P� 5(   "    P� Property � �� �� Empty P� Value# Z 6:   . �5)   &   ��  �� Property � �� �� Value# [  6C   5*   #   P� 5+   "    � �� 6:   Z� . �5,   &   ��  � ��# [  6C   5-   #   P� 5.   "    �@J�IsKeyboardFocused$
 True��6G   . �5/   &   ��  � ��
 �����6C   50   #   52      .��53   %   54      �� 55      $��20��6?   $��20��6J   $��	-30,0,0,0q�6V   ��6   �� *CloseApplicationCommand+.��56      �� $*��$F:\VSCode\MVVM4\glass_location_solid��6   $��15��6J   57      58   	   �� 59      $	��160��62   ��6   �� *	Date[0]+.��5:      �� .+�5;      �� ��6   �� *Description[0]+�� 5<      ��6   �� *Temperature[0]+5=      5>      5?      �� 5C   
   $��1��6.   $��0��6;   ��6   �� *	Date[1]+.��5D      �� .+�5E      �� ��6   �� *Description[1]+�� 5F      ��6   �� *Temperature[1]+5G      5H      �� 5I   
   $��1��6.   $��1��6;   ��6   �� *	Date[2]+.��5J      �� .+�5K      �� ��6   �� *Description[2]+�� 5L      ��6   �� *Temperature[2]+5M      5N      �� 5O   
   $��1��6.   $��2��6;   ��6   �� *	Date[3]+.��5P      �� .+�5Q      �� ��6   �� *Description[3]+�� 5R      ��6   �� *Temperature[3]+5S      5T      �� 5U   
   $��1��6.   $��3��6;   ��6   �� *	Date[4]+.��5V      �� .+�5W      �� ��6   �� *Description[4]+�� 5X      ��6   �� *Temperature[4]+5Y      5Z      5[      5\      