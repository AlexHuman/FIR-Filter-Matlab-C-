function [timeMass, sourceMass] = GenerateSourceValues(massAmpl, massFreq, period, measures) 
timeMoment = 0;
time = [];
source = [];
for i=1:measures
    X=0;
    
    for j=1:max(size(massAmpl))
        X = X + massAmpl(j)* sin(2*pi*massFreq(j)*timeMoment);
    end
    
    time = [time timeMoment];
    source = [source X];
    timeMoment = timeMoment + period;
end
  
timeMass = time; 
sourceMass = source;