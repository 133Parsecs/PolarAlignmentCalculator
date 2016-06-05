#Welcome to the PolarAlignmentCalculator

This is a simple calculator to compute polar alignment based on given parameters.  It is based on Frank Barrett's 2008 paper.

The paper is based on "Hook's Method" from the February 1989 issue of the Journal of the British Astronomical Society.
In it, Hook " ...derived a number of equations which showed how far a star would drift [...] and the alignment tolerances required to hold field rotation to within a given limit."

By solving for individual parameters, the equations can answer questions such as: 
1. "What is my polar alignment error"
2. "How do I know when my alignment is "Good Enough?"
3. "What is the longest exposure time I can use before star trails become evident."

###Using It
The whole program is one executable.  You do not need any sort of installer.  If you just want to run the program, download the executable and run it.  Or, you can download the code and build it.
You may need to right click on the exe and select "Unblock" before windows will let you run it.

##Here is some basic information on the parameters:

### Focal Length
"...AS the focal length increases, the polar alignment tolerance decreases, assuming all other factors remain constant. This effect is predominantly due to the image scale reduction at longer focal lengths. The star trail created by the field rotation will occupy more pixels or film grains. To hold [tau] constant, therefore, will reqquire more accurate polar alignment.

###Guide Star Angle
The angle of the guide star to the imaging region is often overlooked when thinking about guiding. Barrett's paper discusses this in moderate length.

###Exposure Time
"As exposure time increases, polar alignment tolerance decreases."

###Field Rotation
This is how much the field, in microns, is going to rotate given the other parameters.  You can either set this parameter or solve for it.

###Declination of Target
This is another factor that often seems to be overlooked.  The higher the declination, the less tolerance there is in polar alignment. Barrett's paper discusses this phenomena.

###References
Barret, http://celestialwonders.com/articles/polaralignment/PolarAlignmentAccuracy.pdf
