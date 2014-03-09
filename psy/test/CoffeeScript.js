(function() {
  var cube, error, number, opposite, square;

  number = 42;

  opposite = true;

  if (opposite) {
    number = -42;
  }

  if (opposite != null) {
    alert("I know it!");
  }

  try {
    allHellBreaksLoose();
  } catch (_error) {
    error = _error;
    print(error);
  } finally {
    cleanUp();
  }

  square = function(x) {
    return x * x;
  };

  cube = function(x) {
    return square(x) * x;
  };

}).call(this);
