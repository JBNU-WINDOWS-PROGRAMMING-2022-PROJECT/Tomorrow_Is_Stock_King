# 내일은 주식왕

## git branch 전략

> 메인 브랜치 : main

> 보조 브랜치 : feature
>
> > feaure 브랜치 명명 방식은 feature/[기능이름]

> 릴리즈 브랜치 : release
>
> > dev ->release -> main

> 핫픽스 브랜치 : hotfix
>
> > main -> hotfix -> main

&nbsp;

## Commit, PR시
- Rule 1 : Commit양식은 아래를 따릅니다.   
- Rule 2 : 제목은 영어로, 본문은 한글로 작성하여 주세요.

```
# <타입>: <제목>

##### 제목은 최대 50 글자까지만 입력 ############## -> |


# 본문은 위에 작성
######## 본문은 한 줄에 최대 72 글자까지만 입력 ########################### -> |

# 꼬릿말은 아래에 작성: ex) #이슈 번호

# --- COMMIT END ---
# <타입> 리스트
#   feat    : 기능 (새로운 기능)
#   fix     : 버그 (버그 수정)
#   refactor: 리팩토링
#   style   : 스타일 (코드 형식, 세미콜론 추가: 비즈니스 로직에 변경 없음)
#   docs    : 문서 (문서 추가, 수정, 삭제)
#   test    : 테스트 (테스트 코드 추가, 수정, 삭제: 비즈니스 로직에 변경 없음)
#   chore   : 기타 변경사항 (빌드 스크립트 수정 등)
# ------------------
#     제목 첫 글자를 대문자로
#     제목은 명령문으로
#     제목 끝에 마침표(.) 금지
#     제목과 본문을 한 줄 띄워 분리하기
#     본문은 "어떻게" 보다 "무엇을", "왜"를 설명한다.
#     본문에 여러줄의 메시지를 작성할 땐 "-"로 구분
# ------------------  
```

```
ex)   
docs: Update README

가독성이 더 좋은 commit 메시지로 업데이트 하였습니다.
```

## 주석 Convention
- Rule 3 : 파일, 함수의 전체적인 기능을 알아보기 쉽게 작성하여 주세요.

```
 /**
  *@author Suin-Jeong, suin8@jbnu.ac.kr
  *@date 2022-04-13
  *@description 상단에 고정적으로 위치하는 Header
  *             로고, Main Navigator, 검색창,
  *             KR/EN 버튼, Side Navigator 포함
  */
```
  
- Rule 4 : 세부 설명이 필요한 경우 코드 위쪽에 한줄주석을 사용해 주세요.

```
// 한줄 주석
```

## Code Convention
Rule 5 : 중괄호는 절대 생략하지 않습니다.   

```
if(a == 0)
{
  b = 10;
}
```

Rule 6 : if문과 else if, else문은 줄바꿈을 하고 사용해 주세요.

```
if(a == 0)
{
  b = 10;
}
else if(b == 0)
{
  b = 20;
}
else
{
  b = 30;
}
```

## Code Review
Rule 7: PR된 Code를 Review하시고 이상 없어보이면 LGTM(Look Good To Me) 댓글을 남겨주세요.   
Rule 8: 더 좋은 방법이나 수정하면 좋을 것 같은 부분 댓글로 남겨주세요.   
Rule 9: Code에 관련된 부분만 지적하여 주세요.   
Rule 10: 상호 코드리뷰가 완료되면 Merge합니다.   
