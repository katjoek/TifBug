# CCITT 3 Fax TIF Bug

This code reproduces what I think is a bug in the code that generates a CCITT 3 Fax formatted TIF file.
It loads a 2bpp png file ("pattern.png") and saves it in the TIF format as "result.tif".

If you compare the two bitmaps, you'll see that in the result.tif is different from pattern.png in the bottom part of the image, starting at line 2679.
While creating the tif file, it seems that the code simply skipped line 2679.

For reference, the file "incorrect result.tif" contain the incorrect result which should be the same as the result.tif file that is created when running the application.