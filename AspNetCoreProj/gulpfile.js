/// <binding BeforeBuild='default' Clean='clean:all' />
/*
This file in the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require('gulp'),
    rimraf = require('rimraf');


var js = [
    './node_modules/es6-shim/es6-shim.min.js',
    './node_modules/systemjs/dist/system-polyfills.js',
    './node_modules/angular2/es6/dev/src/testing/shims_for_IE.js',
    './node_modules/angular2/bundles/angular2-polyfills.js',
    './node_modules/systemjs/dist/system.src.js',
    './node_modules/rxjs/bundles/Rx.js',
    './node_modules/angular2/bundles/angular2.dev.js',
    './node_modules/angular2/bundles/http.dev.js',
    //'./node_modules/bootstrap/dist/js/bootstrap.js',
];

var css = [
    './node_modules/bootstrap/dist/css/bootstrap.css',
    './css/styles.css'
];

var fonts = [
     './node_modules/bootstrap/dist/fonts/*.*'
];

var paths = {
    webroot: './wwwroot/'
};

paths.js = paths.webroot + 'js/**/*.js';
paths.css = paths.webroot + 'css/**/*.css';
paths.fonts = paths.webroot + 'fonts/**/*.*'

gulp.task('clean:js', function (cb) {
    rimraf(paths.js, cb);
});

gulp.task('clean:css', function (cb) {
    rimraf(paths.css, cb);
});

gulp.task('clean:fonts', function (cb) {
    rimraf(paths.fonts, cb);
});

gulp.task('copy:js', function () {
    js.forEach(function (file) {
        gulp.src(file)
            .pipe(gulp.dest('./wwwroot/js'));
    });
});

gulp.task('copy:css', function () {
    css.forEach(function (file) {
        gulp.src(file)
            .pipe(gulp.dest('./wwwroot/css'));
    });
});

gulp.task('copy:fonts', function () {
    fonts.forEach(function (file) {
        gulp.src(file)
            .pipe(gulp.dest('./wwwroot/fonts'));
    });
});

gulp.task('clean:all', ['clean:js', 'clean:css', 'clean:fonts']);
gulp.task('copy:all', ['copy:js', 'copy:css', 'copy:fonts']);
gulp.task('default', ['copy:all']);