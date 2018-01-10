(car '(rose violet daisy buttercup))
(cdr '(rose violet daisy buttercup))
(cons 'pine '(fir oak maple))

#Region "Collapsible Region"  

(car '(rose violet daisy buttercup))
(cdr '(rose violet daisy buttercup))
(cons 'pine '(fir oak maple))  

#End Region

(defun cube (num)
(* num (* num num)))

(defun negativep (num)
(not (> num 0)))

(defun only-atoms (listx)
(cond ((null listx) t)
((atom listx) 2)
((atom (first listx)) (only-atoms (rest listx)))
(nil (+ 1 (only-atoms (first listx))
(only-atoms (rest listx))))))

#Region "Exponent Region" 

(defun expon (base powr)
(cond ((zerop powr) 1)
((evenp powr) (expon (* base base ) (truncate powr 2)))
(t (* base (expon (* base base) (truncate powr 2))))))

#End Region

#Region "Squash Region" 

(defun squash (list1)
(cond ((null list1) nil)
((atom list1) (list list1))
(t (append (squash (car list1))
(squash (cdr list1))))))

#End Region

(defun count-it (itemx listx)
(setq listx (squash listx))
(cond ((null listx) '0)
((atom listx) '0)
((cond ((not (equal itemx (car listx))) (count-it itemx (cdr listx)))
(t (1+ (count-it itemx (cdr listx))))))))

#Region "Fibonacci Region" 

(defun fibonacci (n)
(cond ((= n 0) 1)
((= n 1) 1)
(t (+ (fibonacci (- n 1))
(fibonacci (- n 2))))))

#End Region

#Region "Reverse Region" 

(defun reverse1 (l)
(cond ((null l) nil)
(t (append (reverse1 (cdr l)) (list (car l))))))

#End Region

(defun find-size (l)
(cond ((null l) 0)
(t (1+ (find-size (cdr l))))))

(defun nth-it (n l)
(cond ((null l) nil)
((eq n 1) (car l))
(t (nth-it (- n 1) (cdr l)))))

#Region "Robot Region" 

(defun fill-fg-tap (fourgal)
(cond ((= fourgal 4) 'fourgal-full)
(t (setq fourgal (+ 1 fourgal))
(fill-fg-tap fourgal))))

(defun fill-ng-tap (ninegal)
(cond ((= ninegal 9) 'ninegal-full)
(t (fill-ng-tap (+ 1 ninegal)))))


(defun fill-fg-from-ng(ninegal fourgal)
(cond ((= ninegal 0) 'ninegal-is-empty)
((= fourgal 4) 'fourgal-is-full)
(t (fill-fg-from-ng((- ninegal 1)(+ fourgal 1))))))

(defun fill-ng-from-fg(ninegal fourgal)
(cond ((= fourgal 0) 'fourgal-is-empty)
((= ninegal 9) 'ninegal-is-full)
(t (fill-ng-from-fg((- fourgal 1)(+ ninegal 1))))))

(defun dump-jug (ajug)
(cond ((= ajug 0) 'the-jug-is-empty)
(t (dump-jug (- ajug 1)))))

(setq fourgal 0)
(setq ninegal 0)

#End Region