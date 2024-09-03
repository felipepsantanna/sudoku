module.exports = {
  async redirects() {
    return [
      {
        source: '/',
        destination": "https://rocktools.com.br/sudoku.html", 
       "statusCode": 301
      },
    ]
  },
}
