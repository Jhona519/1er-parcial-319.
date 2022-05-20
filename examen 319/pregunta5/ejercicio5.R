data("iris")
iris
plot(x=iris$Sepal.Length, y=iris$Sepal.Width)
plot(x=iris$Sepal.Length, y=iris$Sepal.Width, col=c("red","yellow","grey")[iris$Species])
