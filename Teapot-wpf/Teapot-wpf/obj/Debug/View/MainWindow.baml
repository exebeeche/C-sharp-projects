   M S B A M L   `   `   `  ����E  ATeapot-wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Teapot_wpf.ModelTeapot_wpf.Model  5   	        Teapot_wpf.View.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Teapot_wpf.Model     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � DataContext 5	         Teapot_wpf.Model.Teapot  5
   
   .��5      �  � ShowGridLines .  � RowDefinitions 5   
   �� 5      $��40 �6   6*   �� 5      $��30 �6   6*   �� 5      $��30 �6   6*   �� 5      $	��100 �6   6+    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   .+�5   
   �� $��0��6   $��0��6%   .+�5      �� -   5         ��Name$ textBlockModel��5      $��Model��60   �� 5      -   5         ��Name$ comboBoxModel��5      ��6.   �� *Model+5      �� 5   
   $��1��6   $��0��6&   .+�5      �� -   5        $ textBlockMaxVolume��5      ��64   �� *	maxVolume+5      �� 5    
   $��0��6   $��1��6%   .+�5!      �� -   5        $ textBoxTempLimit��5!      $��Max Temperature 100C��62   5"      �� 5#   
   $��1��6   $��1��6%   $��3��62   .+�5$      �� $E��?C:\github\C-sharp-projects\Teapot-wpf\Teapot-wpf\img\teapot.png��6   $
��Fill=�6]   5%      �� 5&   
   $��0��6   $��2��6%   .+�5'      �� -   5         ��Name$ 
buttonTemp��5'      $��80��6)   $��20��64   $��Temperature��6@   6V   5(      �� 5)   
   $��0��6   $��4��6%   .+�5*      �� -   5         ��Name$ textBoxTemp��5*      5+      �� 5,   
   $��2��6   $��1��6%   .+�5-      �� -   5        $ textBoxVolumeLimit��5-      $��Max Volume:��64   5.      �� 5/   
   $��2��6   $��4��6%   .+�50      �� -   5        $ textBoxVolume��50      51      �� 52   
   $��2��6   $��2��6%   .+�53      �� -	   5        $ buttonVolume��53      $��80��6+   $��20��66   $��Volume��6B   54      56      57      