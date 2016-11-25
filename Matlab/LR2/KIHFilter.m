function [filteredValues] = KIHFilter(source,filterValues) 

resultY = [];
for i = 1:max(size(source))
    interimY = filterValues * 0;
    
    for j = 1:max(size(filterValues))
        if ((i-j)>0)
            interimY(j) = source(i-j) * filterValues(j);
        else 
            interimY(j) = 0;
        end
    end
    resultY = [resultY sum(interimY)];
        
end
  
filteredValues = resultY; 
