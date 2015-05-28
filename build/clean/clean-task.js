var config = require('../config.json');
var gulp   = require('gulp');
var del    = require('del');
var log    = require('../logger.js');

gulp.task('clean-js', function (done) {
	del([config.app + '/**/*.js', config.app + '/**/*.map'], done);
});

gulp.task('clean-css', function (done) {
	del([config.stylesRoot + '/**/*.css'], done);
});