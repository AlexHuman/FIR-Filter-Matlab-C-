massA = [9, 11, 15, 17, 21, 29, 35];
massF = [10, 11, 12, 13, 15, 20, 25];
massH =  [
              -1.25937288E-0002
              -2.68906576E-0002
               7.24777621E-0002
              -1.01029481E-0001
               6.35336599E-0002
               5.55492140E-0002
              -2.12490481E-0001
               3.24046289E-0001

              -3.24046289E-0001
               2.12490481E-0001
              -5.55492140E-0002
              -6.35336599E-0002
               1.01029481E-0001
              -7.24777621E-0002
               2.68906576E-0002
               1.25937288E-0002];
           
period = 1/ (max(massF)*2*pi);
[time, source] = GenerateSourceValues(massA, massF, period, measures);
filtered = KIHFilter(source, massH);
plot(time, source);
figure; 
plot(time, filtered);