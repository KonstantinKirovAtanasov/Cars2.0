   M S B A M L   `   `   `  ����B  >Cars2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Cars2._0.ViewModelsCars2._0.ViewModels  5      #    Cars2._0.Views.ListedCarsView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0vm!clr-namespace:Cars2._0.ViewModels     5        � DataContext  5	      -  'Cars2._0.ViewModels.ListedCarsViewModel  5
   
   .��5      �  � RowDefinitions 5   
   �� 5      $��8* �6   6*   �� 5      $��1* �6   6*   .+�5   
   � $��0��6   .+�5      ��  J� IsManipulationEnabled .   �� SelectedItem 5      ��  �� Path$ SelectedCar� �� Mode$ OneWayToSource=���5      �� $
 Cars���5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6%   .+�5      �� $	��128��6$   $	��128��63   $	��128��6C   $	��128��6S   $
��Fill=�6b    �� StretchDirection$
 Both=�6q   $��5q�6�   $
��Left=�6�   ��6�   �� $ 
PictureOne�6�   �� 5      $	��128��6$   $	��128��63   $	��128��6C   $	��128��6S   $
��Fill=�6b   $
 Both=�6q   $��5q�6�   $
��Left=�6�   ��6�   �� $ 
PictureTwo�6�   �� 5      $	��128��6$   $	��128��63   $	��128��6C   $	��128��6S   $
��Fill=�6b   $
 Both=�6q   $��5q�6�   $
��Left=�6�   ��6�   �� $ PictureTree�6�   �� 5      $ Vertical=�6)   .+�5   "   �� $��20(�6H   $��Oblique$�6V   $	��Top=�6j   ��6,   �� $ Title�6�   �� 5   "   $��Двигател:��6,   $��Bottom=�6=   $
��Left=�6X   �� 5   "   $��Bottom=�6I   $��Right=�6d   ��6,   �� $ Engine�6�   �� 5    "   $��Пробег:��6,   �� 5!   "   $��Bottom=�6J   $��Right=�6e   ��6,   �� $ MileAge�6�   5"      5#      5$      5&      5'      5(      5)      