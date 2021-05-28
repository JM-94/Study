library(devtools)
# install_github('dkahle/ggmap')
library(ggmap)

apikey = 'AIzaSyALS-1jL0Er7swyhrCbzxnAlMm1rhwgc6A'

register_google(apikey)
ggDaegu <- get_googlemap('daegu',maptype='hybrid')
ggmap(ggDaegu)

ggSeoul <- get_googlemap('seoul',maptype='hybrid')
ggmap(ggSeoul)

ggGrumant <- get_googlemap('Grumant',maptype='hybrid')
ggmap(ggGrumant)
